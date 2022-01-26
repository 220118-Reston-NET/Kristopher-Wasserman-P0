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
            List<Customers>CustomerList = new List<Customers>();//_repo.GetCustomers();
            if(CustomerList.Count != 0)
            {
               return _repo.AddCustomer(p_name);
            }
            else
            {
                throw new Exception("There is already a customer by this name");
            }
        }

        public ItemsLines AddInventory(ItemsLines p_inv)
        {
            throw new NotImplementedException();
        }
    }
}