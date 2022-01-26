using LakeJacksonCyclingModel;

namespace LakeJacksonCyclingDL
{
    public interface IRepository
    {
           ItemsLines AddProduct( ItemsLines p_item);
           Customers AddCustomer( Customers p_name);
           /// <summary>
            ///     Gets the current list of customers within the database.
            /// </summary>
            /// <returns></returns>
           // List<Customers> GetCustomers();
    }
}

