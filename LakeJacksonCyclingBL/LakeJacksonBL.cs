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

        public Products AddProduct(Products p_name)
        {
            return _repo.AddProduct(p_name);
        }

        public List<Products> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }

        public List<Customers> SearchCustomer(string p_name)
        {
            List<Customers> CustomerList = _repo.GetAllCustomers();

            return CustomerList.Where(cList => cList.Name.Contains(p_name)).ToList();
        }
        

        

        public List<Products> SearchProducts(string p_name)
        {
            List<Products> ProductList = _repo.GetProducts();
            return ProductList.Where(pList => pList.ItemName.Contains(p_name)).ToList();
        }

       
        public List<Customers> GetAllCustomers()
        {
             return _repo.GetAllCustomers();
        }

        

        public Customers GetCustomerById(int customerID)
        {
            return GetAllCustomers().Where(customer => customer.cId.Equals(customerID)).First();
        }

        public Orders PlaceOrder(int customerID, int storeID, List<ItemLines> _cart)
        {
            return _repo.PlaceOrder(customerID, storeID, _cart);
        }

        public List<StoreFrontModel> GetAllStoreFront()
        {
            return _repo.GetAllStoreFront();
        }


        public Products GetAllProductByStoreID(int storeid)
        {
            return GetAllProducts().Where(storeID=> storeID.Equals(storeID)).First();
        }
    }
}