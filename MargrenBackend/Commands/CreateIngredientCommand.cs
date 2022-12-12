namespace MargrenBackend.Commands
{
    public record CreateIngredientCommand(int id_ingredient, int id_product, int id_prescription, int amount, string units);
    
}
