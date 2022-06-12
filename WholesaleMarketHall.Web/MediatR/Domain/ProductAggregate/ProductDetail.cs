using WholesaleMarketHall.Web.MediatR.DomainCore;

namespace WholesaleMarketHall.Web.MediatR.Domain.ProductAggregate
{
    public class ProductDetail : Entity
    {
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string? Warehouse { get; set; }
        public int ProductId { get; set; }

        public ProductDetail(decimal minPrice, decimal maxPrice, string? warehouse, int productId)
        {
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            Warehouse = warehouse;
            ProductId = productId;
        }
    }
}
