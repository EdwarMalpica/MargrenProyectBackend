namespace MargrenBackend.Commands
{
    public record UpdatePersonCommand(int personId, string first_name, string last_name, string gender, string type_document, string num_document);
}
