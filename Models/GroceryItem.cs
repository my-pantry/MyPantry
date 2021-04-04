using System;

namespace MyPantry.Models
{
    public class GroceryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PurchaseDate { get; set; }
        public string ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public string Barcode { get; set; }

    }
}