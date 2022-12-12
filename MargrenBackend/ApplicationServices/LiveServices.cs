using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using Margren.Infrastructure;
using MargrenBackend.Commands;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
//using MargrenBackend.Queries;

namespace MargrenBackend.ApplicationServices
{
    public class LiveServices
    {
        private readonly IPersonRepository repository;
        private readonly IUserRepository userRepository;
        //private readonly PersonQueries personQueries;
        private IConfiguration config;

        public LiveServices(IPersonRepository repository, IUserRepository userRepository, IConfiguration config
            )
        {

            this.repository = repository;
            this.userRepository = userRepository;
            this.config = config;
            //this.personQueries = personQueries;
        }
        //PERSONAS
        public async Task<ContentResponse> HandleCommand(CreatePersonCommand createPerson)
        {
            
            var person = new Person();
            person.setId(createPerson.personId);
            person.setFirstName(PersonName.Create(createPerson.first_name));
            person.setLastName(PersonName.Create(createPerson.last_name));
            person.setGender(Gender.create(createPerson.gender));
            person.setTypeDocument(TypeDocument.create(createPerson.type_document));
            person.setNumDocument(NumDocument.create(createPerson.num_document));
            await repository.AddPerson(person);
            //return ContentResponse.createResponse(true, "PERSONA CREADA", null);
            return ContentResponse.createResponse(true, "Persona Creada", person);
            //var person = new Person(
                //PersonId.create(createPerson.personId));
           // person.setName(PersonName.Create(createPerson.Name));
            //await repository.AddPerson(person);
        }
        public async Task<Person> GetPersonById(int id)
        {
            var response = await repository.GetPersonById(PersonId.create(id));

            return response;
        }
        public async Task<ContentResponse> HandleCommand(UpdatePersonCommand updatePersonCommand)
        {
            Person person = await repository.GetPersonById(PersonId.create(updatePersonCommand.personId));
            if(person != null)
            {
                string first_name = string.IsNullOrEmpty(updatePersonCommand.first_name) ? person.first_name.Value : updatePersonCommand.first_name;
                person.setFirstName(PersonName.Create(first_name));
                string last_name = string.IsNullOrEmpty(updatePersonCommand.last_name) ? person.last_name.Value : updatePersonCommand.last_name;
                person.setLastName(PersonName.Create(last_name));
                string gender = string.IsNullOrEmpty(updatePersonCommand.gender)? person.gender.value: updatePersonCommand.gender;
                person.setGender(Gender.create(gender));
                string type_document = string.IsNullOrEmpty(updatePersonCommand.type_document) ? person.type_document.value : updatePersonCommand.type_document;
                person.setTypeDocument(TypeDocument.create(type_document));
                string num_document = string.IsNullOrEmpty(updatePersonCommand.num_document) ? person.num_document.value : updatePersonCommand.num_document;
                person.setNumDocument(NumDocument.create(num_document));
                await repository.UpdatePerson(person);
                return ContentResponse.createResponse(true, "Persona Actualizada", person);
            }
            return ContentResponse.createResponse(false, "No se pudo actualizar la persona", "Persona No encontrada");

        }

        //USERS
        public async Task<User> HandleCommand(CreateUserCommand createUser)
        {

            var user = new User();
            user.id_user = createUser.id_user;
            user.email = Email.create(createUser.email);
            user.rol_name = RolName.create(createUser.rol_name);
            user.id_person = PersonId.create(createUser.id_person);
            user.password = Hash.create(createUser.password);
            await userRepository.AddUser(user);

            return user;
        }
        public async Task<ContentResponse> GetUserById(int id)
        {
            var response = await userRepository.GetUserById(UserId.create(id));
            if(response != null)
            {
                return ContentResponse.createResponse(true,"Usuario Encontrado", response);
            }
            return ContentResponse.createResponse(false, "Usuario no encontrado", null);
           

        }
        public async Task<ContentResponse> HandleCommand(UpdateUserCommand updateUserCommand)
        {
            User user = await userRepository.GetUserById(UserId.create(updateUserCommand.id_user));
            if (user != null)
            {
                string email = string.IsNullOrEmpty(updateUserCommand.email) ? user.email.value : updateUserCommand.email;
                user.email = Email.create(email);
                string rol_name = string.IsNullOrEmpty(updateUserCommand.rol_name) ? user.rol_name.value : updateUserCommand.rol_name;
                user.rol_name = RolName.create(rol_name);
                return ContentResponse.createResponse(true, "Se actualizo el Usuario", user);
            }
            return ContentResponse.createResponse(false, "No se pudo actualizar la persona", "Persona No encontrada");

        }

        //LOGIN
        public async Task<ContentResponse> HandleCommand(LoginComand loginCommand)
        {
            try
            {
                User user = await userRepository.GetPasswordByEmail(Email.create(loginCommand.email));
                if (user != null)
                {
                    Password login = new Password(user.password.value);
                    if (login != null)
                    {
                        if (login.password.value.SequenceEqual(Hash.create(loginCommand.password).value))
                        {
                            //int id_user = await userRepository.GetIdPersonByLogin(UserLogin.create(loginCommand.login));
                            //if (id_user == 0)
                            //{
                            //    return ContentResponse.createResponse(true, "INACTIVO", "El usuario cuenta con un estado inactivo");
                            //}
                            //Console.WriteLine("Antes");
                            string role = await userRepository.getRoleByIdUser(user.email);
                            //Console.WriteLine("" + role);
                            return ContentResponse.createResponse(true, "LOGIN", generateToken(role, loginCommand.email, user.id_user));
                        }
                        return ContentResponse.createResponse(false, "CONTRASEÑA INCORRECTA", null);
                    }
                }
                
                return ContentResponse.createResponse(false, "USUARIO NO ENCONTRADO", null);
            }
            catch (Exception ex)
            {
                return ContentResponse.createResponse(false, "ERROR AL REALIZAR LOGIN", ex.Message);
            }
        }


        //TOKEN
        private string generateToken(string role, string email, int id_user)
        {
            List<Claim> claimList = new List<Claim>();
            claimList.Add(new Claim("role", role));
            claimList.Add(new Claim("email", email));
            claimList.Add(new Claim("id_person", id_user.ToString()));

            var claims = claimList.ToArray();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("JWT:Key").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var securityToken = new JwtSecurityToken(
                                     claims: claims,
                                     expires: DateTime.Now.AddHours(8),
                                     signingCredentials: creds);

            var token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;
        }


    }
}
