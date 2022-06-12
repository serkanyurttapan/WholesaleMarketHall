using WholesaleMarketHall.Web.MediatR.DomainCore;

namespace WholesaleMarketHall.Web.MediatR.Domain.ProductAggregate
{
    public class Product : Entity, IAggrateRoot
    {
        public string? Name { get; set; }
        private readonly List<ProductDetail> _productDetails;
        public IReadOnlyCollection<ProductDetail> ProductDetails => _productDetails;
        public Product()
        {
        }

        public Product(string? name, List<ProductDetail> productDetails)
        {
            Name = name;
            _productDetails = productDetails;
        }
        //public decimal GetAveragePrice => _productDetails.Average(x => x.MaxPrice + x.MinPrice) / 2;
    }
}
