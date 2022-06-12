namespace WholesaleMarketHall.Web.MediatR.Application.Dtos
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string? Warehouse { get; set; }
        public int ProductId { get; set; }
    }
}
