namespace MargrenBackend.Commands
{
    public record CreateRLShopCommand(int id_shopList, int id_inventory, int quantity, int price, string units, int id_product);
    
}
