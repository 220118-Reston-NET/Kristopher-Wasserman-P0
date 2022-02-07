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

        public ItemsLines AddProduct(ItemsLines p_name)
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

        public List<ItemsLines> GetAllProducts()  
        {
            List<ItemsLines>listOfProducts = new List<ItemsLines>();
            string sqlQuery = "Select * from Products";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery,con);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    listOfProducts.Add(new ItemsLines(){
                        itemID = reader.GetInt32(3),
                        ItemName = reader.GetString(0),
                        Description = reader.GetString(1),
                        Price = reader.GetDouble(2)
                    });
                }
            }
            return listOfProducts;
        }

        public List<Customers> GetCustomers()
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
                        Zip = reader.GetInt32(4),
                        Email = reader.GetString(5),
                        PhoneNumber = reader.GetString(6)
                    });
                }
            return ListOfCustomers;

            }
        }

        

        public List<ItemsLines> GetProducts()
        {
            List<ItemsLines>ListOfProducts = new List<ItemsLines>();
            string sqlQuery = "Select * from Products";
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery,con);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    ListOfProducts.Add(new ItemsLines(){
                        itemID = reader.GetInt32(3),
                        ItemName = reader.GetString(0),
                        Description = reader.GetString(1),
                        Price = reader.GetDouble(2),

                    });

                }
            return ListOfProducts;
            }
        }
    }
}