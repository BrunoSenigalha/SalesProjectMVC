﻿using SalesWebMvc.Data;

namespace SalesWebMvc.Models.Services
{
    public class SellerService(SalesWebMvcContext context)
    {
        private readonly SalesWebMvcContext _context = context;

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }
    }
}