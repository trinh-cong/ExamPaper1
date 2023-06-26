using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaper
{
     abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Producer { get; set; }
        public string Contructor { get; set; }
        public Product(int id, string name, double price, string producer, string contructor)
        {
            Id = id;
            Name = name;
            Price = price;
            Producer = producer;
            Contructor = contructor;
        }
        public abstract double ComputeTax();
    }
     class Book : Product
    {
        public Book(int id, string name, double price, string producer, string contructor) : base(id, name, price, producer, contructor) { }

        public override double ComputeTax()
        {
            return Price * 0.08;
        }

    }
     class MobilePhone : Product
    {
        public MobilePhone(int id, string name, double price, string producer, string contructor) : base(id, name, price, producer, contructor) { }

        public override double ComputeTax()

        {
            return Price * 0.10;
        }
    }




}

