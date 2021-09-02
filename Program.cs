using System;
using System.Collections.Generic;
using System.Linq;

namespace T_Shirt
{
    class TShirt
    {
        public string size;
        public string colour;
        public float price;
        public string image;

        public TShirt(string valueSize, string valueColour, float valuePrice, string valueImage)
        {
            size = valueSize;
            colour = valueColour;
            price = valuePrice;
            image = valueImage;
        }
    }

    class Address
    {
        public string street;
        public string city;
        public string zipCode;

        public Address(string streetName, string cityName, string zipCodeNumber)
        {
            street = streetName;
            city = cityName;
            zipCode = zipCodeNumber;
        }
    }


    class User
    {
        public string name;
        public string email;

        public User(string userName)
        {
            name = userName;
        }
    }

    class ShoppingCart
    {
        public List<float> orderTshirt;
        public List<Address> Home;

        public ShoppingCart()
        {
            orderTshirt = new List<float>();
            Home = new List<Address>();
        }

        public void AddPrice(float order)
        {
            orderTshirt.Add(order);
        }

        public void AddAddress(Address home)
        {
            Home.Add(home);
        }

        public void GetTotal()
        {
            Console.WriteLine(orderTshirt.Sum());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User customer = new User("Jame");
            customer.email = "jame@gmail.com";

            Address home = new Address("131/75, Puttamonthon", "Nakornprathom", "10180");

            TShirt tshirt_1 = new TShirt("L", "Red", 500, "Bird");
            TShirt tshirt_2 = new TShirt("M", "Black", 750, "Geometry");
            TShirt tshirt_3 = new TShirt("S", "White", 625, "Polka Dot");

            ShoppingCart cart = new ShoppingCart();
            cart.AddPrice(tshirt_1.price);
            cart.AddPrice(tshirt_2.price);
            cart.AddPrice(tshirt_3.price);
            cart.AddAddress(home);

            cart.GetTotal();
        }
    }
}
