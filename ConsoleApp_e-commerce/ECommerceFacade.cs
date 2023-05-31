using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public class ECommerceFacade
    {
        public static UserTransacions userTransacions;
        public static Seller seller;
        public static Customer customer;
        public static MyBasket mybasket;
        public static Favorites favorites;
        public static Products products;
        public static Payment payment;

        public static Dress dress;
        public static Pants pants;
        public static Tshirt tshirt;

        public ECommerceFacade()
        {
            userTransacions = new UserTransacions();
            seller = new Seller();
            customer = new Customer();
            mybasket = new MyBasket();
            favorites = new Favorites();
            products = new Products();  
            payment = new Payment();
            dress = new Dress();
            pants = new Pants();
            tshirt = new Tshirt();
        }

        public void UserStart()
        {
            seller.Start();
            customer.Start();
            dress.Start();
            pants.Start();
            tshirt.Start();

            int transaction = -1;

            while (true)
            {
                Console.WriteLine("1- Seller");
                Console.WriteLine("2- Customer");
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == 1)
                {
                    User.userType = UserType.Seller;
                    break;
                }

                else if (transaction == 2)
                {
                    User.userType = UserType.Customer;
                    break;
                }
                else
                {
                    Console.WriteLine("You made the wrong choice");  //Yanlış tercih yaptınız
                }
            }
            userTransacions.UserTransactionsMenu();

            if (User.userType.Equals(UserType.Customer))
            {
                CustomerStart();
            }
            else
            {
                SellerStart();
            }
        }

        public void CustomerStart()
        {
            int transaction = -1;
            while (true)
            {
                Console.WriteLine("1- Account information"); //Hesap bilgileri
                Console.WriteLine("2- Products");  //Ürünlerini görüntüle
                Console.WriteLine("3- My Basket");   //Sepetim
                Console.WriteLine("4- Favorites");   //Favoriler
                Console.WriteLine("5- Payment");  //Ödeme
                Console.WriteLine("6- Logout");  //Çıkış yap
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == (int)CustomerAccountType.AccountInformation)
                {
                    userTransacions.CustomerUser();
                }
                else if (transaction == (int)CustomerAccountType.Products)
                {
                    products.ProductsList();
                    customer.ProductsList();
                }
                else if (transaction == (int)CustomerAccountType.MyBasket)
                {
                    mybasket.MyBasketList();
                }
                else if (transaction == (int)CustomerAccountType.Favorites)
                {
                    favorites.FavoritesList();
                }
                else if (transaction == (int)CustomerAccountType.Payment)
                {
                    if (User.login)
                        payment.PaymentListFinding();

                    else
                        Console.WriteLine("Log in");  // Oturum aç
                }
                else if (transaction == (int)CustomerAccountType.Logout)
                {
                    return;
                }
            }
        }

        public void SellerStart() 
        {
            int transaction;
            while (true)
            {
                Console.WriteLine("1- Account information"); //Hesap bilgileri
                Console.WriteLine("2- View your products");  //Ürünlerini görüntüle
                Console.WriteLine("3- Add product");   //Ürün ekle
                Console.WriteLine("4- Delete product");   //Ürün Sil
                Console.WriteLine("5- Logout");  //Çıkış yap
                transaction = Convert.ToInt32(Console.ReadLine());

                if (transaction == (int)SellerAccountType.AccountInformation)
                {
                    userTransacions.SellerUser();
                }
                else if (transaction == (int)SellerAccountType.ViewYourProducts)
                {
                    products.SellerProductsList();
                }
                else if (transaction == (int)SellerAccountType.AddProduct)
                {
                    products.ProductAdd();
                }
                else if (transaction == (int)SellerAccountType.DeleteProduct)
                {
                    products.SellerProductsList();
                    seller.DeleteProduct();
                }
                else if (transaction == (int)SellerAccountType.Logout)
                {
                    return;
                }
            }
        }

    }
}
