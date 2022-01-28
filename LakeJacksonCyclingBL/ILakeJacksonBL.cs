using LakeJacksonCyclingModel;


namespace LakeJacksonCyclingBL
{
    /// <summary>
    /// This Data layer is used to make things happen. 
    /// </summary>
    public interface ILakeJacksonBL
    {
        /// <summary>
        /// Function below will add inventory to the stores application. 
        /// </summary>
        /// <param name="p_inv"></param>
        /// <returns></returns>
        ItemsLines AddInventory(ItemsLines p_inv);

        /// <summary>
        /// Adds a customer to our customer database 
        /// </summary>
        /// <param name="p_name">name is being used to add to the database</param>
        /// <returns></returns>
        Customers AddCustomer(Customers p_name);
        List<Customers> SearchCustomer(string name);

        


    }
}


