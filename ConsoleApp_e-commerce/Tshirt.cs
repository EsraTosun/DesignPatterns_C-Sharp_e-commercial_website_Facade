using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    public class Tshirt : Products    //Tişört
    {
        public Tshirt()
            :base()
        {

        }

        public Tshirt(int UserId, int ID, String brand, int amount, String color, String productsType,
            String Patterns, String Bodys, String FabricType)
            : base(UserId, ID, brand, amount, color, productsType, Patterns, Bodys, FabricType)
        {

        }

        public void Start()
        {
            Products products = new Products(201, 1005,
                Enum.GetName(typeof(BrandType), 1),
                100,
                Enum.GetName(typeof(ColorType), 2),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 1),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 2));
            Products products1 = new Products(202, 1006,
                Enum.GetName(typeof(BrandType), 3),
                100,
                Enum.GetName(typeof(ColorType), 1),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 2));
            Products products2 = new Products(203, 1007,
                Enum.GetName(typeof(BrandType), 3),
                100,
                Enum.GetName(typeof(ColorType), 3),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 2),
                Enum.GetName(typeof(BodyType), 1),
                Enum.GetName(typeof(FabricType), 1));
            Products products3 = new Products(200, 1008,
                Enum.GetName(typeof(BrandType), 0),
                100,
                Enum.GetName(typeof(ColorType), 2),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 3),
                Enum.GetName(typeof(FabricType), 1));
            Products products4 = new Products(201, 1009,
                Enum.GetName(typeof(BrandType), 1),
                100,
                Enum.GetName(typeof(ColorType), 1),
                Enum.GetName(typeof(ProductsType), 2),
                Enum.GetName(typeof(PatternsType), 3),
                Enum.GetName(typeof(BodyType), 2),
                Enum.GetName(typeof(FabricType), 0));

            Products.productList.Add(products);
            Products.productList.Add(products1);
            Products.productList.Add(products2);
            Products.productList.Add(products3);
            Products.productList.Add(products4);
        }

        public override void SellerProductsList()  //Satıcı Ürünleri Listele
        {
            List<Products> result = productList.Where(x => x.UserID == User.USERID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 2))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public override void ProductsList()  //Ürünleri Listele
        {
            List<Products> result = productList.Where(
             x => x.productType.Equals(Enum.GetName(typeof(ProductsType), 2))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public override void ProductDelete()
        {
            int index = productList.FindIndex(r => r.ID == Seller.DesiredID &&
             r.productType.Equals(Enum.GetName(typeof(ProductsType), 2)));

            if (index >= 0) 
                productList.RemoveAt(index);
        }

        public override void FindingDesiredProduct()
        {
            List<Products> result = productList.Where(x => x.ID == Customer.DesiredID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 2))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
