using Core.Entities;

namespace Entities.DTOs
{
    public class ProductCreateDto:IDto
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
