namespace LakeJacksonCyclingModel
{
    public class Customers
    {
        public int cId {get;set;}
        public string Name {get;set;}
        public string Address { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        private List<Orders> _orders;
        public List<Orders> Ordered
        {
            get { return _orders; }

            set
            {
                _orders = value;
            }
        }

        
        public override string ToString()
        {
           return $"Id: {cId} \nName: {Name} \n City: {City} \n State: {State}";
        }
    }
}
