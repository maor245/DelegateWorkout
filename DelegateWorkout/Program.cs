////Main method
//StringHelper helper = new StringHelper();


//CountDelegate d1 = helper.GetCount;
//CountDelegate d2 = helper.GetCountSymbolA;

//string testString = "Hello Aloha";
//Console.WriteLine("Characters count: {0}", TestDelegate(d1, testString));
//Console.WriteLine("Characters 'A' count: {0}", TestDelegate(d2, testString));

//static int TestDelegate(CountDelegate method, string testString)
//{
//    return method(testString);
//}


//// Invoke the delegates
//public delegate int CountDelegate(string message);
//public class StringHelper
//{
//    public int GetCount(string inputString)
//    {
//        return inputString.Length;

//    }
//    public int GetCountSymbolA(string inputString)
//    {
//        return inputString.Count(c => c == 'A');
//    }
//    public void Move(int distance)
//    {
//        for (int i = 1; i <= distance; i++)
//        {
//            Thread.Sleep(1000);
//            Console.WriteLine("Moving in progress... covered distance: {0} km", i);
//        }
//    }
//}


//Main method - Client code

StockExachangeMonitor stockExachangeMonitor = new StockExachangeMonitor();
stockExachangeMonitor.PriceChangeHandler = ShowPrice;
stockExachangeMonitor.Start();



static void ShowPrice(int price)
{
    Console.WriteLine($"New price is: {price}");
}

//Server code
public class StockExachangeMonitor
{
    public delegate void PriceChange(int price);
    public PriceChange PriceChangeHandler { get; set; }

    public void Start()
    {
        while (true)
        {
            int bankOfAmericaPrice = (new Random()).Next(100);
            PriceChangeHandler(bankOfAmericaPrice);
            Thread.Sleep(2000);
        }
    }
}