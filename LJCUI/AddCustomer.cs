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
        public void Display()
        {
            Console.WriteLine("[]===== Employee =====[]");
            Console.WriteLine("");
        }

        public string UserInput()
        {
            return "AddCustomer";
        }
        
    }
}