namespace LJCUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Lake Jackson Cycling");
            Console.WriteLine("Can I get your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("OK "+ name +", How may I help you?");
            Console.WriteLine("[1] - View Store Information");
            Console.WriteLine("[2] - View Products");
            Console.WriteLine("[]===== Employee =====[]");
            Console.WriteLine("[5] - Add Customer Information");
            Console.WriteLine("[6] - Add Products");
            Console.WriteLine("[7] - Place an Order");
            Console.WriteLine("[]===== Employee =====[]");
        }
        public string UserInput()
        {
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "0":
                    return "Exit";
                    break;
                case "1":
                    return "StoreInfo";
                    break;
                case "2":
                    return "ViewProducts";
                    break;
                case "5":
                    return "AddCustomer";
                    break;
                case "6":
                    return "AddCustomer";
                    break;
                case "7":
                    return "AddOrders";
                    break;               
                default:
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    break;
            }

            return "MainMenu";
        }
    }
}