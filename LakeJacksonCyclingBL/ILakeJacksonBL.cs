using LakeJacksonCyclingModel;


namespace LakeJacksonCyclingBL
{
    /// <summary>
    /// This Data layer is used to make things happen. 
    /// </summary>
    public interface ILakeJacksonBL
    {
        

        /// <summary>
        /// Adds a customer to our customer database 
        /// </summary>
        /// <param name="p_name">name is being used to add to the database</param>
        /// <returns></returns>
        Customers AddCustomer(Customers p_name);
        List<ItemsLines> SearchProducts(string name);

        List<ItemsLines> GetAllProducts();
        List<Customers> SearchCustomer(string name);


    /// <summary>
    /// this function will add Inventory to the store
    /// </summary>
    /// <param name="p_name"></param>
    /// <returns></returns>
        ItemsLines AddProduct(ItemsLines p_name);




    }
}


