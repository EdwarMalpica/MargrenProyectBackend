namespace MargrenBackend.Commands
{
    public record CreateShopListCommand(int id_shopList, int idUser, DateTime date, int subTotal);
    
}
