using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string? Name { get; set; }
<<<<<<< HEAD
=======
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string? name)
        {
            Id = id;
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
>>>>>>> 05c9177 (Adding other entities and second migration)
    }
}
