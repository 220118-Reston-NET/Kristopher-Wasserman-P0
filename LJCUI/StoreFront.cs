using LakeJacksonCyclingBL;
using LakeJacksonCyclingModel;

namespace LJCUI
{
    public class StoreFront : IMenu
    {
        private static List<StoreFrontModel>  listOfStoreFront = new List<StoreFrontModel>();

        private ILakeJacksonBL _LakeJacksonCycleBL;
      
        public StoreFront(ILakeJacksonBL p_name)
        {
           _LakeJacksonCycleBL = p_name;
            listOfStoreFront =  _LakeJacksonCycleBL.GetAllStoreFront();
        }

        public static StoreFrontModel selectedStore = new StoreFrontModel();
        public void Display()
        {
            Console.WriteLine("What location would you like to shop at?");
             foreach (var storeid in listOfStoreFront)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(storeid);
            }
            Console.WriteLine("[1] - Please enter a id to begin order");
            Console.WriteLine("[0] - Go Back");

        }

        public string UserInput()
        {
           string asn = Console.ReadLine();
            switch(asn)
            {
               
                case "1":
                    Console.WriteLine("Please Enter your ID");
                    int storeID = Convert.ToInt32(Console.ReadLine());  
                    while(listOfStoreFront.All(store => store.storeId != storeID))
                    {
                        Console.WriteLine("Please Enter your ID");
                        storeID = Convert.ToInt32(Console.ReadLine());  

                    }    
                     selectedStore = _LakeJacksonCycleBL.GetAllProductByStoreID(storeId);//_LakeJacksonCycleBL.GetCustomerById(storeID);
                     return "StoreMenu";
                
                case "0":
                    return "MainMenu";
                default:
                    return "PlaceOrder";
            }
        }
    }
}