using System;
using System.Collections.Generic;

namespace PaymentsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var payment = new PaymentCrediCard(dueDate: DateTime.Now);
            var obj = new ComparingObj(id: 1);
            var objTwo = new ComparingObj(id: 1);
            obj.Equals(objTwo);
            // payment.DueDate = DateTime.Now;
            // payment.DueDate.
            // Console.WriteLine(payment.DueDate);

            var pay = new PaymentDelegate.Pay(ProcessPay);
            pay(24);

            var lists = new List<string>();
            lists.Add("Opa");
            lists.Add("Hi");
            lists.Add("Hello");
            lists.Add("Hola");

            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }

        }

        static void ProcessPay(double value)
        {
            Console.WriteLine($"Got {value}");
        }
    }

    public class ComparingObj : IEquatable<ComparingObj>
    {
        public ComparingObj(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

        public bool Equals(ComparingObj obj)
        {
            return true;
        }
    }

    public class PaymentDelegate
    {
        public delegate void Pay(double value);
    }

    public abstract class Payment : IPayment
    {
        public Payment(DateTime dueDate)
        {
            DueDate = dueDate;
        }
        private DateTime _dueDate;
        public DateTime DueDate
        {
            get
            {
                Console.WriteLine("Reading value...");
                return _dueDate;
            }
            set
            {
                Console.WriteLine("Setting value...");
                _dueDate = value;
            }
        }

        public int Value { get; set; }
        public virtual void ProcessesPayment(string number) { }
        public virtual void ProcessesPayment(string number, DateTime dueDate) { }
        public void Pay(double price) { throw new NotImplementedException(); }
    }

    public class PaymentBill : Payment
    {
        public PaymentBill(DateTime dueDate) : base(dueDate)
        {
            Console.WriteLine("Calling mother class.");
        }
        public string BillNumber;
        public override void ProcessesPayment(string number) { }
    }

    public class PaymentCrediCard : Payment
    {
        public PaymentCrediCard(DateTime dueDate) : base(dueDate) { }

        public override void ProcessesPayment(string price) { Console.WriteLine(" "); }
    }

    public class PaymentPix : Payment
    {
        public PaymentPix(DateTime dueDate) : base(dueDate) { }

        public override void ProcessesPayment(string price) { Console.WriteLine(" "); }
    }

    public interface IPayment
    {
        int Value { get; set; }
        void Pay(double price);
    }

}
