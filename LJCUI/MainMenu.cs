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

            return "MainMenu";
        }
    }
}