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

        private ILakeJacksonBL _LakeJacksonCycleBL;
        public AddCustomer(ILakeJacksonBL p_name)
        {
           _LakeJacksonCycleBL = p_name;
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
            Console.WriteLine("[6] - Phone: " + _cInfo.PhoneNumber);
            Console.WriteLine("[7] - Email: " + _cInfo.Email);
            Console.WriteLine("[9] - Save");
            Console.WriteLine("[]===== Employee =====[]");
            Console.WriteLine("[0] - Go Back");
        }

        public string UserInput()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Please enter customers Name. ");
                    _cInfo.Name = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Please enter thier address.");
                    _cInfo.Address = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Please enter the City.");
                    _cInfo.City = Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Please enter the State.");
                    _cInfo.State = Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Please enter the Zip(numbers only please)");
                    _cInfo.Zip = Convert.ToInt32(Console.ReadLine());
                    break;
                case "6":
                    Console.WriteLine("Please enter a phone number!(numbers only please)");
                    _cInfo.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                    break;
                case "7":
                    Console.WriteLine("Please enter a email.");
                    _cInfo.Email = Console.ReadLine();
                    break;
                case "9":
                    try
                    {
                        Log.Information("CustomerAdded!");
                        Console.WriteLine("CustomerAdded");
                        _LakeJacksonCycleBL.AddCustomer(_cInfo);
                        Console.ReadLine();
                    }
                    catch (System.Exception exc)
                    {
                        Log.Warning("Customer already added");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue!");
                        Console.ReadLine();
                    }
                    return "AddCustomer";
                    break;
                case "0":
                    return "MainMenu";
                    break;
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