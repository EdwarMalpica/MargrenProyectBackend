namespace MargrenBackend.Commands
{
    public record CreateStepCommand(int id_step, int id_prescription, string description);
   
}
