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
            List<Customers> CustomerList = _repo.GetCustomers();
            if(_repo.GetCustomers() != null)
            {
              return _repo.AddCustomer(p_name);
            }
            else
            {
                throw new Exception("There are no customers ordering from us.");
            }
        }

        public ItemsLines AddInventory(ItemsLines p_inv)
        {
            throw new NotImplementedException();
        }

        public List<Customers> SearchCustomer(string p_name)
        {
            List<Customers> CustomerList = _repo.GetCustomers();

            return CustomerList.Where(cList => cList.Name.Contains(p_name)).ToList();
        }
    }
}