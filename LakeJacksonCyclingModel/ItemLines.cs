namespace LakeJacksonCyclingModel
{
    public class ItemsLines
    {
        private string _itemName;
        public string ItemName
        {
            get {return _itemName; }
            set
            {
                if(value != "")
                {
                    _itemName = value;
                }
                else
                {
                    throw new Exception("Please enter a name for the item");

                }
            }
            
        }
        private int _quantity;
        public int Quantity
        {
            get { return _quantity;  }
            set
            {
                if(value >= 0)
                {
                    _quantity = value;
                }
                else
                {
                    throw new Exception("Quantity can not be less than 0,This means we dont have anything!");
                }
            }
        }

        public ItemsLines()
        {
            ItemName = "Bib Shorts";
            Quantity = 100;

            ItemName = "Shorts";
            Quantity = 10;
        }
        
        
    }
}