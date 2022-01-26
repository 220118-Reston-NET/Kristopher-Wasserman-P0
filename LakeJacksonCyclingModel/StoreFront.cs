namespace LakeJacksonCyclingModel
{
    public class StoreFront
    {
        public string StoreName {get;set;}
        public string Address {get;set;}

        public List<Orders> Orders;
        public List<ItemsLines> ItemsLines;

    }
}