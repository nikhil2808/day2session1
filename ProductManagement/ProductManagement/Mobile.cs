using System;


namespace productmanagement
{
    class Mobile : Product
    {
        int batteryLife;
        string cameraSpec;
        string displayGlass;

        internal Mobile()
        {
            Console.WriteLine("Mobile Default Constructor Called");
        }

        internal Mobile(int productId, string model, string brand, int price,
            int batteryLife, string cameraSpec, string displayGlass) : base(productId, model, brand, price) //invokes parent class parameterized constructor
        {
            Console.WriteLine("Mobile Parameterized Constructor Called");
            this.batteryLife = batteryLife;
            this.cameraSpec = cameraSpec;
            this.displayGlass = displayGlass;
        }

        internal void SetMobileData(int productId, string model, string brand, int price, int batteryLife, string cameraSpec, string displayGlass)
        {
            base.SetProductData(productId, model, brand, price);
            this.batteryLife = batteryLife;
            this.cameraSpec = cameraSpec;
            this.displayGlass = displayGlass;
        }

        internal override void Display()
        {
            base.Display();
            Console.WriteLine($"BatteryLife : {batteryLife} CameraSpec : {cameraSpec} DisplayGlass : {displayGlass}");
        }
    }
}