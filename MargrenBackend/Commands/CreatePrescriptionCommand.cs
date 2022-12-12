namespace MargrenBackend.Commands
{
    public record CreatePrescriptionCommand(int id_prescription, string type_prescription, string name, string difficulty, int hour, int minute, int seconds);
    
}
