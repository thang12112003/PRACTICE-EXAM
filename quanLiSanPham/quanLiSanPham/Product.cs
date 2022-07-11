using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLiSanPham
{
     class Product
    {
        public int iDProduct { get; set; }
        public string nameProduct { get; set; }
        public double priceProduct { get; set; }

        public void EnterProduct()
        {
            Console.WriteLine("Nhap Id san pham");
            iDProduct= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten san pham: ");
            nameProduct= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap gia san pham: ");
            priceProduct= Double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return this.iDProduct + "\t" +
                this.nameProduct + "\t" +
                this.priceProduct;
        }

    }
}
