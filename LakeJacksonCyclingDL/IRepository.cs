using LakeJacksonCyclingModel;

namespace LakeJacksonCyclingDL
{
    public interface IRepository
    {
           ItemsLines AddProduct( ItemsLines p_name);
           Customers AddCustomer( Customers p_name);
           /// <summary>
            ///     Gets the current list of customers within the database.
            /// </summary>
            /// <returns></returns>
            List<Customers> GetCustomers();
            List<ItemsLines> GetProducts();
            List<ItemsLines> GetAllProducts();
    }
}

