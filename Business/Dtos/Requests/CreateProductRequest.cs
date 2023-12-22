﻿namespace Business.Dtos.Requests
{
    public class CreateProductRequest
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}
