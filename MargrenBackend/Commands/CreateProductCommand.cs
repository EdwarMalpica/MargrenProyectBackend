namespace MargrenBackend.Commands
{
    public record CreateProductCommand(int id_product, string name_product, string type, int price, string units, string description);
    
}
