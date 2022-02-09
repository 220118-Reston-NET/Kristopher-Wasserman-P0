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
        List<Products> SearchProducts(string name);

        List<Products> GetAllProducts();

        List<Customers> GetAllCustomers();
        List<Customers> SearchCustomer(string name);

       Customers GetCustomerById(int customerID);

       Products GetAllProductByStoreID(int storeid);

      List<StoreFrontModel> GetAllStoreFront();

    /// <summary>
    /// this function will add Inventory to the store
    /// </summary>
    /// <param name="p_name"></param>
    /// <returns></returns>
        Products AddProduct(Products p_name);

       Orders PlaceOrder(int customerID, int storeID, List<ItemLines> _cart);


    }
}


