namespace MargrenBackend.Commands
{
    public record UpdateUserCommand(int id_user, string email, string rol_name, int id_person, string password);
    
}
