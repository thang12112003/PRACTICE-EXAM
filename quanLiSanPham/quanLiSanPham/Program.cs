using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiSanPham
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product productss = new Product();
        
           
            int chon = 0;
            do
            {
                Menu();
                 chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {

                    case 1:
                        productss.EnterProduct();
                        products.Add(productss);
                        goto case 4;
                        break;
                    case 2:
                        Console.WriteLine("\n\n                 Danh sach san pham la: \n");
                        foreach (Product product in products)
                        {
                            Console.WriteLine(product+ "\n");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Nhap ID san pham muon xoa");
                        int xoa = Convert.ToInt32(Console.ReadLine());
                        foreach(Product product in products)
                        {
                            if(product.iDProduct== xoa)
                            {
                                products.Remove(product);
                                Console.WriteLine("Xoa san pham thanh cong");
                            }
                        }
                        Console.WriteLine("Id ban muon xoa khong ton tai!");
                        break;
                    case 4:
                        Console.WriteLine("Tam biet! \n");
                        break;

                        default:
                        Console.WriteLine("Nhap sai thong tin");
                        break;
                }
            }while (chon!=4);
            //Console.WriteLine("Ban co muon tiep tuc chuong trinh khong");
            //Console.WriteLine("Y/N");
            //char a = 'Y';
            //if (a == 'Y')
            //{
                
            //}
            
        }
        private static void Menu()
        {
            Console.WriteLine("Chon Menu: ");
            Console.WriteLine(" 1.Them ho so san pham. \n 2. Hien thi ho so san pham. \n 3.Xoa san pham theo id. \n 4. Thoat");
        }
    }
}
