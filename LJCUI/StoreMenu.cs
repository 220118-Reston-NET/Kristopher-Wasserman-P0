using LakeJacksonCyclingBL;
using LakeJacksonCyclingModel;

namespace LJCUI
{
    public class StoreMenu : IMenu
    {
        private static List<Products>  listOfProducts = new List<Products>();
        public static StoreFrontModel selectedStore = new StoreFrontModel();
        private ILakeJacksonBL _LakeJacksonCycleBL;
      
        public StoreMenu(ILakeJacksonBL p_name)
        {
           _LakeJacksonCycleBL = p_name;
            listOfProducts =  _LakeJacksonCycleBL.GetAllProductByStoreID(StoreFrontModel.selectedStore.storeId);
        }
        private List<ItemLines> _cart = new List<ItemLines>();
        public void Display()
        {
            Console.WriteLine("What location would you like to shop at?");
             foreach (var _productInfo in listOfProducts)
            {

                Console.WriteLine("-------------------");
                Console.WriteLine(_productInfo);
            }
            Console.WriteLine("[1] - Please enter a id to begin order");
            Console.WriteLine("[2] - Place Order");
            Console.WriteLine("[0] - Go Back");
        }


        public string UserInput()
        {
            
            string asn = Console.ReadLine();
            switch(asn)
            {

               
                case "1":
                    Console.WriteLine("Please Enter your  product ID");
                    int productID = Convert.ToInt32(Console.ReadLine());  
                    while(listOfProducts.All(product => product.productID != productID))
                    {
                        Console.WriteLine("Please Enter your ID");
                        productID = Convert.ToInt32(Console.ReadLine());  

                    }  
                    Console.WriteLine("How much would you like to buy?");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    _cart.Add(new ItemLines()
                    {
                        productid = productID,
                        quantity = quantity
                    });   
                     return "StoreMenu";
                case "2":
                    Console.WriteLine("Your Order has been submitted");
                    _LakeJacksonCycleBL.PlaceOrder(PlaceOrder.selectedCustomer.cId, StoreFront.selectedStore.storeId, _cart);
                    Console.WriteLine("Will now return you to main menu");
                    return "MainMenu";
                case "0":
                    return "MainMenu";
                default:
                    return "PlaceOrder";
            }
        }
    }
}