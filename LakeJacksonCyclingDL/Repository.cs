using System.Text.Json;
using LakeJacksonCyclingModel;

namespace LakeJacksonCyclingDL
{
    public class Repository : IRepository
    {
        private string _filepath = "../LakeJacksonCyclingDL/Database/";
        private string _jsonString;

        /// <summary>
        /// saves products the inventory. this is to be used to view them at a later time
        /// </summary>
        /// <param name="p_item"></param>
        /// <returns></returns>
        public ItemsLines AddProduct(ItemsLines p_item)
        {
            string path = _filepath + "Inventory.json";
            List<ItemsLines> listOfItems = new List<ItemsLines>();
            listOfItems.Add(p_item);

            _jsonString = JsonSerializer.Serialize(listOfItems, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return p_item ;
        }

        /// <summary>
        ///  this is to get all the products to show them and make sure that there dulics
        /// </summary>
        /// <returns></returns>
        public List<ItemsLines> GetAllProducts()
        {
            _jsonString = File.ReadAllText(_jsonString + "Inventory.json");

            return JsonSerializer.Deserialize<List<ItemsLines>>(_jsonString);
        }

        public Customers AddCustomer(Customers p_name)
        {
            
            string path = _filepath + "Customers.json";
            List<Customers> CustomerList = GetCustomers();
            CustomerList.Add(p_name);

            _jsonString = JsonSerializer.Serialize(CustomerList, new JsonSerializerOptions { WriteIndented = true});

            File.WriteAllText(path, _jsonString);
            return p_name;
        }

        public List<Customers> GetCustomers()
        {
            _jsonString = File.ReadAllText(_filepath + "Customers.json");
            return JsonSerializer.Deserialize<List<Customers>>(_jsonString);
        }
    }
}