using System;


namespace productmanagement
{
    class Refrigerator : Product
    {
        int door;
        string bodymaterial;


        internal Refrigerator()
        {
            Console.WriteLine("Refrigerator Default Constructor Called");
        }

        internal Refrigerator(int productId, string model, string brand, int price,
            int door, string bodymaterial) : base(productId, model, brand, price)
        {
            Console.WriteLine("Refrigerator Parameterized Constructor Called");
            this.door = door;
            this.bodymaterial = bodymaterial;

        }

        internal void SetRefrigeratorData(int productId, string model, string brand, int price, int door, string bodymaterial)
        {
            base.SetProductData(productId, model, brand, price);
            this.door = door;
            this.bodymaterial = bodymaterial;
        }

        internal override void Display()
        {
            base.Display();
            Console.WriteLine($"Door : {door}  BodyMaterial : {bodymaterial}");
        }
    }
}