namespace LakeJacksonCyclingModel
{
    public class ItemsLines
    {
        public int itemID {get;set;}
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

        private string _iDescription;
        public string Description
        {
            get { return _iDescription;}
            set
            {
                if(value != "")
                {
                    _iDescription = value;
                }
                else
                {
                    throw new Exception("Product must have a description.");
                }
            }
        }
        private double _itemPrice;
        public double Price
        {
            get {return _itemPrice ;}
            set
            {
                if(value != 0.00)
                {
                    _itemPrice = value;
                }
                else
                {
                    
                    throw new Exception("Please enter a valid price. Above 0.00");
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
            Description = "Bike shorts that will last for a 12 hr ride in the saddle";
            Price = 150.20;
            Quantity = 100;
        }
        
        public override string ToString()
        {
            return $"ID: {itemID}\n Name: {ItemName}";
        }
    }
}