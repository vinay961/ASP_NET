
namespace Practice
{
    public delegate void PriceDropHandler(string stockName, double price);
    class Stock
    {
        public string? StockName { get; }
        public double Price { get; private set; }
        public double Threshold { get; }
        public event PriceDropHandler? Dropped;

        public Stock(string stockName, double price, double threshold)
        {
            StockName = stockName;
            Price = price;
            Threshold = threshold;
        }

        public void UpdatePrice(double price)
        {
            Price = price;
            Console.WriteLine($"Updated price of {StockName}: {Price}");

            if (Price < Threshold)
            {
                Dropped?.Invoke(StockName, Price);
            }
        }
    }
    class StockMonitor
    {
        public void OnPriceDrop(string stockName, double price)
        {
            Console.WriteLine($"ALERT: {stockName} price dropped to {price}!");
        }
    }
    class StockPriceAlert
    {
        //static void Main(string[] args)
        //{
        //    Stock appleStock = new Stock("Apple", 150, 140);
        //    StockMonitor monitor = new StockMonitor();

        //    appleStock.Dropped += monitor.OnPriceDrop;
        //    appleStock.UpdatePrice(145);
        //    appleStock.UpdatePrice(135);
        //}
    }
}
