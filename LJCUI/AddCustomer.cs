using LakeJacksonCyclingModel;
using LakeJacksonCyclingBL;


namespace LJCUI
{
        /// <summary>
        /// Function inside here will look at Customers Model with in th LakeJacksonCyclingModel.
        /// if you need to change or add things please remeber to add them to the model as well
        /// </summary>
    public class AddCustomer : IMenu
    {
        private static Customers _cInfo = new Customers();

        private ILakeJacksonBL _ljcBL;
        public AddCustomer(ILakeJacksonBL p_name)
        {
           _ljcBL = p_name;
        }

        // private ILakeJackson;
        public void Display()
        {
            Console.WriteLine("[]===== Employee =====[]");
            Console.WriteLine("[1] - Name: " + _cInfo.Name);
            Console.WriteLine("[2] - Address: "+_cInfo.Address);
            Console.WriteLine("[3] - City: " + _cInfo.City);
            Console.WriteLine("[4] - State: " + _cInfo.State);
            Console.WriteLine("[5] - Zip: " + _cInfo.Zip);
            Console.WriteLine("[7] - Phone: " + _cInfo.PhoneNumber);
            Console.WriteLine("[8] - Email: " + _cInfo.Email);
            Console.WriteLine("[2] - Save");
            Console.WriteLine("[]===== Employee =====[]");
        }

        public string UserInput()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Please enter customers Name: ");
                    _cInfo.Name = Console.ReadLine();
                    break;
                case "2":
                    try
                    {
                        _ljcBL.AddCustomer(_cInfo);
                    }
                    catch (System.Exception exc)
                    {
                        Log.Warning("Customer already added");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue!");
                        Console.ReadLine();
                    }
                    return "MainMenu";
                default:
                    Console.WriteLine("Ivalid Option. Please try again");
                    Console.WriteLine("Please press Enter to continue.");
                    Console.ReadLine();
                    return "AddCustomer";
                    break;
            }
            return "AddCustomer";
        }
        
    }
}