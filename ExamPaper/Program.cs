using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[6];
            product[0] = new Book(1, "Sách 1", 100, "Nhà sản xuất 1", "Nhà xây dựng 1");
            product[1] = new Book(2, "Sách 2", 150, "Nhà sản xuất 2", "Nhà xây dựng 2");
            product[2] = new Book(3, "Sách 3", 200, "Nhà sản xuất 3", "Nhà xây dựng 3");
            product[3] = new MobilePhone(4, "Điện thoại 1", 1000, "Nhà sản xuất 4", "Nhà xây dựng 4");
            product[4] = new MobilePhone(5, "Điện thoại 2", 1500, "Nhà sản xuất 5", "Nhà xây dựng 5");
            product[5] = new MobilePhone(6, "Điện thoại 3", 2000, "Nhà sản xuất 6", "Nhà xây dựng 6");



            double totalBookTax = 0;
            double totalPhoneTax = 0;
             

            foreach (Product sp in product)
            {
                {
                    if (sp is Book book)
                    {
                        totalBookTax += book.ComputeTax();
                    }
                    else if (sp is MobilePhone mobilePhone)
                    {
                        totalPhoneTax += mobilePhone.ComputeTax();
                    }
                    

                }
            }

            Console.WriteLine("total Book Tax is: " + totalBookTax);
            Console.WriteLine("total Mobile Phone Tax is: " + totalPhoneTax);
            double tongthue = totalBookTax + totalPhoneTax;
            Console.WriteLine("Tổng thuế các sản phẩm: " + tongthue);

            Console.ReadLine();


        }
       
        }
    }

