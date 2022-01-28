namespace LakeJacksonCyclingModel
{
    public class Products
    {
        private string _name;
        public string Name
        {
            get { return _name;} 
            set
            {
                if(value != "")
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("There must be a name for the product");
                }
            }
        }

        private int _price;
        public int Price
        {
            get{ return _price ;}
            set
            {
                if(value >= 0)
                {
                    _price = value;
                }
                else 
                {
                    throw new Exception("Please enter a price for the product");
                }
            }
        }

        private string? _desc;
        public string Descrpition 
        {
            get { return _desc;}
            set
            {
                if(value != "")
                {
                    _desc = value;

                }
                else
                {
                    throw new Exception("Please enter a Description for the Product");
                }
            }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if(value >= 0)
                {
                    _quantity = value;
                }
                else
                {
                    throw new Exception("Please enter a quantity for the product");
                }
            }
            
        }


    }
    
}