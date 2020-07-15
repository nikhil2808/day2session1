using System;


namespace productmanagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Mobile mobile = new Mobile();
            mobile.SetMobileData(1665, "7pro", "oneplus", 51000, 12, "48MP", "Toughened glass");
            mobile.Display();
            Console.ReadLine();

            Product p1 = new Mobile(1666, "11", "iphone", 74000, 8, "13MP", "Toughened glass");





            Refrigerator refrigerator = new Refrigerator();
            refrigerator.SetRefrigeratorData(1665, "x", "godrej", 54000, 2, "plastic");
            refrigerator.Display();
            Console.ReadLine();

            Product p2 = new Refrigerator(1666, "y", "LG", 60000, 3, "glass");
            DisplayProduct(p1);
            DisplayProduct(p2);
        }

        static void DisplayProduct(Product product)
        {
            if (product.GetType() == typeof(Mobile))
                ((Mobile)product).Display();

            if (product.GetType() == typeof(Refrigerator))
                ((Refrigerator)product).Display();


        }


    }
}