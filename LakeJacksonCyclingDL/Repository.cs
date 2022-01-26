using System.Text.Json;
using LakeJacksonCyclingModel;

namespace LakeJacksonCyclingDL
{
    public class Repository : IRepository
    {
        private string _filepath = "../LakeJacksonCyclingDL/Database";
        private string _jsonString;

        public ItemsLines AddProduct(ItemsLines p_item)
        {
            string path = _filepath + "Inventory.json";
            List<ItemsLines> listOfItems = GetAllProducts();
            listOfItems.Add(p_item);

            _jsonString = JsonSerializer.Serialize(listOfItems, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return p_item ;
        }
        public List<ItemsLines> GetAllProducts()
        {
            _jsonString = File.ReadAllText(_jsonString + "Inventory.json");

            return JsonSerializer.Deserialize<List<ItemsLines>>(_jsonString);
        }
    }
}