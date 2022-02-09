using LakeJacksonCyclingBL;
using LakeJacksonCyclingModel;


namespace LJCUI
{
    public class PlaceOrder : IMenu
    {
        
        private static Customers _cInfo = new Customers();

        private ILakeJacksonBL _LakeJacksonCycleBL;
        private List<Customers> listOfCustomers;
        public PlaceOrder(ILakeJacksonBL p_name)
        {
           _LakeJacksonCycleBL = p_name;
            listOfCustomers =  _LakeJacksonCycleBL.GetAllCustomers();
        }

        public static Customers selectedCustomer = new Customers();
        public void Display()
        {
           
            foreach (var _customerInfo in listOfCustomers)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(_customerInfo);
            }
            Console.WriteLine("[1] - Please enter a id to begin order");
            Console.WriteLine("[0] - Go Back");
            
            // {
            //     Console.WriteLine("===== Lake Jackson Cycling ======");
            //     Console.WriteLine("!! Please select an option to change the Order Information !!");
            //     Console.WriteLine("== [1] Customer Name: "+ _cInfo.Name);
            //     Console.WriteLine("== [2] Customer Address:" + _cInfo.Address);
            //     Console.WriteLine("== [3] Customer City: "+ _cInfo.City);
            //     Console.WriteLine("== [4] Customer State: " + _cInfo.State);
            //     Console.WriteLine("== [5] Customer Zip: "+ _cInfo.Zip);
            //     Console.WriteLine("== [6] Customer Phone: "+_cInfo.PhoneNumber);
            //     Console.WriteLine("== [7] Product ID: " );
            //     Console.WriteLine("== [8] Place Order");
            // }
            
        }

        public string UserInput()
        {
            string asn = Console.ReadLine();
            switch(asn)
            {
               
                case "1":
                    Console.WriteLine("Please Enter your ID");
                    int customerID = Convert.ToInt32(Console.ReadLine());  
                    while(listOfCustomers.All(customer => customer.cId != customerID))
                    {
                        Console.WriteLine("Please Enter your ID");
                        customerID = Convert.ToInt32(Console.ReadLine());  

                    }    
                     selectedCustomer = _LakeJacksonCycleBL.GetCustomerById(customerID);
                     return "StoreFront";
                
                case "0":
                    return "MainMenu";
                default:
                    return "PlaceOrder";
            }
        }
    }
}