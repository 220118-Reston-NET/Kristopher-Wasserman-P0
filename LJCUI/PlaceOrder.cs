using LakeJacksonCyclingModel;


namespace LJCUI
{
    public class PlaceOrder : IMenu
    {
        private static Customers _cInfo = new Customers();
        private static Employee _eInfo = new Employee();
        public void Display()
        {
            if(_eInfo.isEmployee == 1)
            {
                Console.WriteLine("===== Lake Jackson Cycling ======");
                Console.WriteLine("!! Please select an option to change the Order Information !!");
                Console.WriteLine("== [1] Customer Name: "+ _cInfo.Name);
                Console.WriteLine("== [2] Customer Address:" + _cInfo.Address);
                Console.WriteLine("== [3] Customer City: "+ _cInfo.City);
                Console.WriteLine("== [4] Customer State: " + _cInfo.State);
                Console.WriteLine("== [5] Customer Zip: "+ _cInfo.Zip);
                Console.WriteLine("== [6] Customer Phone: "+_cInfo.PhoneNumber);
                Console.WriteLine("== [7] Product ID: " );
                Console.WriteLine("== [8] Place Order");
            }
            else
            {
                Log.Warning("A customer tried to Access the Place Order Function");
                Console.WriteLine("Please See an Employee to place an order");
                Console.WriteLine("Please press Enter to contiune");
                Console.ReadLine();
            }
        }

        public string UserInput()
        {
            string asn = Console.ReadLine();
            switch(asn)
            {
                case "1":
                    return "PlaceOrder";
                default:
                    return "PlaceOrder";
            }
        }
    }
}