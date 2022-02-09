namespace LakeJacksonCyclingModel
{
    public class Orders
    {
        public int orderID {get;set;}
        private List<ItemLines> _itemLine;
        public int orderTotal;
        public List<ItemLines> LineItems
        {
            get { return _itemLine; }
            set
            {
                _itemLine = value;
            }
        }
    }
}