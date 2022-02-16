using LakeJacksonCyclingBL;
using LakeJacksonCyclingModel;

namespace LJCUI
{
    public class ReplemishInventory : IMenu
    {
        List<Inventory> listOfInventory = new List<Inventory>();
        
        private static List<StoreFrontModel>  listOfStoreFront = new List<StoreFrontModel>();
        public static StoreFrontModel selectedStore = new StoreFrontModel();

        private ILakeJacksonBL _LakeJacksonCycleBL;
        
        public ReplemishInventory(ILakeJacksonBL p_name)
        {
           _LakeJacksonCycleBL = p_name;
            listOfInventory = _LakeJacksonCycleBL.GetAllInventoryByStoreId(StoreFrontUI.selectedStore.storeId);
        }
        public void Display()
        {
            Console.WriteLine("What store would you like to replemish the inventory?");
            foreach (var _storeFront in listOfStoreFront)
            {
                
            }
        }

        public string UserInput()
        {
            throw new NotImplementedException();
        }
    }
}