using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        // int x; class'ın içinde direkt olarak tanımlanırsa field

        //public int y { get; set; } //class içinde get ve set ile tanımlanırsa property

       /* void test()
        {
            int z; //metod içinde tanımlanırsa değişken
        }
       */

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public  bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; } //1'e çok ilişki formatı 
        







    }
}
/*  
 Field-Variable-Propert
 */
