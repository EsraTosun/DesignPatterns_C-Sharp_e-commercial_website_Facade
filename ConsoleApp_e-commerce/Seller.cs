using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum SellerAccountType   //Satıcı hesap tipleri
    {
        AccountInformation = 1,
        ViewYourProducts = 2,
        AddProduct = 3,
        DeleteProduct = 4,
        Logout = 5,
    }

    public class Seller : User, ISeller
    {
        public static UserTransacions userTransacions = new UserTransacions();

        public static int DesiredID;
        public void AccountInformation()
        {
            UserTransacions userTransacions = new UserTransacions();
            userTransacions.SellerUser();         
        }

        public void AddProduct()
        {
        Products products = new Products();
        products.ProductAdd();
        }

        public void DeleteProduct()  //Ürün tipi
        {
            Products products = new Products();
            Console.WriteLine("Delete ID: ");
            DesiredID = Convert.ToInt32(Console.ReadLine());

            products.ProductDelete();
        }

        public void ViewYourProducts()
        {
            Products products = new Products();
            products.SellerProductsList();
        }

        public static String productsTypeFinding()
        {
            int transactions;
            while (true)
            {
                Console.WriteLine("1- " + ProductsType.pants);
                Console.WriteLine("2- " + ProductsType.tshirt);
                Console.WriteLine("3- " + ProductsType.dress);
                transactions = Convert.ToInt32(Console.ReadLine());

                return Products.ProductsTypelist[transactions];
            }
        }

        public void Start()
        {
            User selleruser = new User(200, "Azra", "Yağız", "123", "azra@gmail.com", "123", "İstanbul");
            User selleruser1 = new User(201, "Mehmet", "Yıldız", "123", "Mehmet@gmail.com", "123", "İstanbul");
            User selleruser2 = new User(202, "Cenk", "Melek", "123", "Cenk@gmail.com", "123", "İstanbul");
            User selleruser3 = new User(203, "Ayşe", "Nehir", "123", "Ayşe@gmail.com", "123", "İstanbul");

            SellerList.Add(selleruser);
            SellerList.Add(selleruser1);
            SellerList.Add(selleruser2);
            SellerList.Add(selleruser3);
        }
    }
}
