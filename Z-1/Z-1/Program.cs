using System;

namespace Z_1
{
    class Bus
    {

        private int numPassengers;
        private double ticketPrice;
        private double cost;
        public Bus()
        {
            numPassengers = 0;
            ticketPrice = 0;
            cost = 0;           
        }
        public void GetInfo()
        {
            Console.WriteLine("Кол-во мест: {0} | Стоимость билета: {1}", numPassengers, ticketPrice);
        }
        public virtual void TotalCost()
        {
            cost = numPassengers * ticketPrice;
        }
        public int NumPassengers { get { return numPassengers; } set { numPassengers = value; } }
        public double TicketPrice { get { return ticketPrice; } set { ticketPrice = value; } }
        public double Cost { get { return cost; } set { cost = value; } }
        public void Input()
        {
            Console.Write("Введите кол-во мест- ");
            numPassengers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость билета- ");
            ticketPrice = Convert.ToDouble(Console.ReadLine());
        }
    }
    class ExpressBus: Bus
    {
        public ExpressBus() : base()
        {            
            Input();
        }        
        public override void TotalCost()
        {
            Cost = (TicketPrice + (TicketPrice * 0.05)) * NumPassengers;
        }
        public void GetInfo()
        {
            Console.WriteLine("Общая стоимость: {0}", Cost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ExpressBus ing = new ExpressBus();
            ing.TotalCost();
            ing.GetInfo();
            Console.ReadLine();
        }        
    }
}
