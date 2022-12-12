namespace MargrenBackend.Commands
{
    public record CreateAddressCommand(int id_addres, string kind_of_street, int number_street, int num_one, int num_two, string description, int id_person, int id_lugar);
    
}
