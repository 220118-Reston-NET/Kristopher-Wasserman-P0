namespace LakeJacksonCyclingModel
{
    public class Orders
    {
        private List<ItemsLines> _itemLine;
        public int orderTotal;
        public List<ItemsLines> LineItems
        {
            get { return _itemLine; }
            set
            {
                _itemLine = value;
            }
        }
    }
}