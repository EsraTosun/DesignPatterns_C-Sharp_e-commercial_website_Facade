using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    enum CustomerAccountType
    {
        AccountInformation = 1,
        Products = 2,
        MyBasket = 3,
        Favorites = 4,
        Payment = 5,
        Logout = 6,
    }
    public class Customer:User, ICustomer  //Müşteri
    {
        public static UserTransacions userTransacions = new UserTransacions();

        public static int DesiredID;

        public static List<String> CustomerAccountTypelist = Enum.GetNames(typeof(CustomerAccountType)).ToList();

        public static int transactionID = -1;
        static int transaction = -1;

        public void AccountInformation()
        {
            UserTransacions userTransacions = new UserTransacions();
            userTransacions.CustomerUser();
        }

        public void ProductsList()    //Ürünler
        {
            
            Console.WriteLine("Enter the ID of the product you have selected");
            //Seçtiğiniz ürünün ID'si giriniz
            transactionID = Convert.ToInt32(Console.ReadLine());

            CustomerListTransactions.MyBasketORFavoritesAdd();
        }

        public void MyBaskets()
        {
            MyBasket myBasket = new MyBasket();
            myBasket.MyBasketList();
        }

        public void Favoritess()
        {
            Favorites favorites = new Favorites();
            favorites.FavoritesList();
        }

        public void PaymentTransaction()
        {
            Payment payment = new Payment();
            payment.PaymentListFinding();
        }

        public void Start()
        {
            User customerruser = new User(100, "Şaziye", "Dağ", "123", "Şaziye@gmail.com", "123", "İstanbul");
            User customerruser1 = new User(101, "Şeyda", "Açıkgöz", "123", "Şeyda@gmail.com", "123", "İstanbul");
            User customerruser2 = new User(102, "Esra", "Tosun", "123", "Esra@gmail.com", "123", "İstanbul");
            User customerruser3 = new User(103, "Bige", "Dua", "123", "Bige@gmail.com", "123", "İstanbul");

            CustomerList.Add(customerruser);
            CustomerList.Add(customerruser1);
            CustomerList.Add(customerruser2);
            CustomerList.Add(customerruser3);
        }
    }
}
