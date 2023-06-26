namespace ExamPaper
{
     class MobilePhone : Product
    {
        public MobilePhone(int id, string name, double price, string producer, string contructor) : base(id, name, price, producer, contructor) { }

        public override double ComputeTax()
       
        {
            return Price * 0.10;
        }
    }




}

