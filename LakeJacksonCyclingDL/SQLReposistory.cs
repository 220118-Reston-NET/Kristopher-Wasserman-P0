using System.Data.SqlClient;
using LakeJacksonCyclingModel;

namespace LakeJacksonCyclingDL
{
    public class SQLRepository : IRepository
    {

        /// <summary>
        /// sql database.
        /// </summary>
        private readonly string _connectionStrings;
        public SQLRepository(string p_connectionStrings)
        {
            _connectionStrings = p_connectionStrings;
        }
        public Customers AddCustomer(Customers p_name)
        {
            string sqlQuery = @"insert into CustomerInfo values(@cName, @Address, @City, @State, @Zip, @Email, @Phone)";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                
                command.Parameters.AddWithValue("@cName", p_name.Name);
                command.Parameters.AddWithValue("@Address", p_name.Address);
                command.Parameters.AddWithValue("@City", p_name.City);
                command.Parameters.AddWithValue("@State", p_name.State);
                command.Parameters.AddWithValue("@Zip", p_name.Zip);
                command.Parameters.AddWithValue("@Email", p_name.Email);
                command.Parameters.AddWithValue("@Phone", p_name.PhoneNumber);

                command.ExecuteNonQuery();
            }
            return p_name;
        }

        public Products AddProduct(Products p_name)
        {
            
            string sqlQuery = @"insert into Products values(@itemName, @Description, @Price)";
            
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();


                SqlCommand command = new SqlCommand(sqlQuery,con);
                
                command.Parameters.AddWithValue("@itemName", p_name.ItemName);
                command.Parameters.AddWithValue("@Description", p_name.Description);
                command.Parameters.AddWithValue("@Price", p_name.Price);
                command.ExecuteNonQuery();
                    
                
            }
        return p_name;
        }

        

        public List<Products> GetAllProducts()  
        {
            List<Products> listOfProducts = new List<Products>();
            string sqlQuery = @"select * from Products p ";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery,con);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    listOfProducts.Add(new Products(){
                        productID = reader.GetInt32(3),
                        ItemName = reader.GetString(0),
                        Description = reader.GetString(1),
                        Price = reader.GetDouble(2)
                    });
                }
            }
            return listOfProducts;
        }

        public List<Customers> GetAllCustomers()
        {
            List<Customers> ListOfCustomers = new List<Customers>();
            string sqlquery = @"Select * from CustomerInfo";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlquery,con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                        ListOfCustomers.Add(new Customers(){
                        cId = reader.GetInt32(7), 
                        Name = reader.GetString(0),
                        Address = reader.GetString(1),
                        City = reader.GetString(2),
                        State = reader.GetString(3),
                        Zip = reader.GetString(4),
                        Email = reader.GetString(5),
                        PhoneNumber = reader.GetString(6)
                    });
                }
            return ListOfCustomers;

            }
        }  
        public List<StoreFrontModel> GetAllStoreFront()
        {
            List<StoreFrontModel> listOfStoreFront = new List<StoreFrontModel>();
            string sqlQuery = @"Select * from StoreFront";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    listOfStoreFront.Add(new StoreFrontModel(){
                        storeId = reader.GetInt32(0),
                        StoreName = reader.GetString(1),
                        Address = reader.GetString(2),
                        Phone = reader.GetString(3)
                    });
                } 
            return listOfStoreFront;
            }
           
        }
        public List<Products> GetProducts()
        {
            List<Products>ListOfProducts = new List<Products>();
            string sqlQuery = "Select * from Products";
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery,con);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    ListOfProducts.Add(new Products(){
                        productID = reader.GetInt32(3),
                        ItemName = reader.GetString(0),
                        Description = reader.GetString(1),
                        Price = reader.GetDouble(2),

                    });

                }
            return ListOfProducts;
            }
        }

        public Orders PlaceOrder(int customerID, int storeID, List<ItemLines> _cart, double totalPrice)
        {
            Orders order = new Orders();
            string sqlQuery = @"insert into Orders values(@storeID, @customerID,@OrderTotal); Select scope_identity()";
            string sqlQuery1 = @"insert into LineItem values(@orderid,  @productid, @quantity)";
            string sqlQuery2 = @"update Inventory 
                                    set quantity = quantity - @Quantity
                                    WHERE storeid = @storeid and productID = @productid";
            
           
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery,con);
                
            
                command.Parameters.AddWithValue("@storeID", storeID);
                command.Parameters.AddWithValue("@customerID", customerID);
                command.Parameters.AddWithValue("@OrderTotal", totalPrice);



                int orderID = Convert.ToInt32(command.ExecuteScalar());
                foreach (var item in _cart)
                {
                    command = new SqlCommand(sqlQuery1,con);
                    command.Parameters.AddWithValue("@orderid", orderID);
                    command.Parameters.AddWithValue("@productid", item.productid);
                    command.Parameters.AddWithValue("@quantity", item.quantity);
                    command.ExecuteNonQuery();

                    command = new SqlCommand(sqlQuery2,con);
                    command.Parameters.AddWithValue("@storeid", storeID);
                    command.Parameters.AddWithValue("@productid", item.productid);
                    command.Parameters.AddWithValue("@Quantity", item.quantity);
                    command.ExecuteNonQuery();
                    
                }
                
            }
            Console.WriteLine("Order Submitted");
            return order;
        }

        public List<Inventory> GetAllInventory()
        {
            string sqlQuery = "select * from Inventory i ";
            List<Inventory> listOfInventory = new List<Inventory>();
           using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery,con);

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    listOfInventory.Add(new Inventory(){
                        productID = reader.GetInt32(0),
                        storeID  = reader.GetInt32(1),
                        Quantity = reader.GetInt32(2)
                    });
                }
            }   
           return listOfInventory;
        }

        public void AddProductToStore(int storeID, int productID, int quantity)
        {
            string sqlQuery = "insert into Inventory values (@productid, @storeid,@quantity)";

             using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery,con);
                
            
                command.Parameters.AddWithValue("@productid", productID);
                command.Parameters.AddWithValue("@storeid", storeID);
                command.Parameters.AddWithValue("@quantity", quantity);

                command.ExecuteNonQuery();

            }
        }
    }
}