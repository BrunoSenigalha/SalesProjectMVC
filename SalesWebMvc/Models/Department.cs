using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string? Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(string? name)
        {
           
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public decimal TotalSales(DateTime initial, DateTime final) 
        { 
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
