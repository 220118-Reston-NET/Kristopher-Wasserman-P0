namespace LakeJacksonCyclingModel
{
    public class StoreFront
    {
        public string StoreName {get;set;}
        public string Address {get;set;}
        public Int64 Phone {get;set;}

        public List<Orders> Orders;
        public List<ItemsLines> ItemsLines;
    public StoreFront()
    {
            StoreName = "Lake Jackson Cycling";
            Address = "123 Oyster Point Blvd, Lake Jackson, TX 77566";
            Phone = 8083989431;

    }
    }
    
}