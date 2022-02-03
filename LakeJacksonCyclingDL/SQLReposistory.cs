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
            throw new NotImplementedException();
        }

        public List<Customers> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public List<ItemsLines> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}