namespace App.Domain.Core
{
    public interface ICanEditProducts
    {
        void AddProduct(IProduct item);
        void RemoveProduct(IProduct item);
        void EditProduct(IProduct item);
        void MakeDiscount(IProduct item, int discountPercent);
    }
}
