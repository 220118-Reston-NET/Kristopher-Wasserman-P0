using LakeJacksonCyclingModel;
using LakeJacksonCyclingDL;

namespace LakeJacksonCyclingBL
{
    public class LakeJacksonBL : ILakeJacksonBL
    {
        /// <summary>
        /// The injection below allows functions to do what they need to get done.
        /// </summary>
        private IRepository _repo;
        public LakeJacksonBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public Customers AddCustomer(Customers p_name)
        {
            
              return _repo.AddCustomer(p_name);
            
        }

        public ItemsLines AddProduct(ItemsLines p_name)
        {
            return _repo.AddProduct(p_name);
        }

        public List<ItemsLines> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }

        public List<Customers> SearchCustomer(string p_name)
        {
            List<Customers> CustomerList = _repo.GetCustomers();

            return CustomerList.Where(cList => cList.Name.Contains(p_name)).ToList();
        }

        public List<ItemsLines> PlaceOrder(string p_name)
        {
             return _repo.PlaceOrder();
        }

        public List<ItemsLines> SearchProducts(string p_name)
        {
            List<ItemsLines> ProductList = _repo.GetProducts();
            return ProductList.Where(pList => pList.ItemName.Contains(p_name)).ToList();
        }

        public List<ItemsLines> ViewProducts(string name)
        {
            throw new NotImplementedException();
        }
    }
}