﻿using Core.Entities;

namespace Entities.Concretes
{
    public class Product : Entity<Guid>
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
        public Category? Category { get; set; }
    }
}
