namespace LakeJacksonCyclingModel
{
    public class Customers
    {
        public string Name {get;set;}
        public string Address { get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public Int64 PhoneNumber { get; set; }

        private List<Orders> _orders;
        public List<Orders> Ordered
        {
            get { return _orders; }

            set
            {
                _orders = value;
            }
        }

        public Customers()
        {
            Name = "Joe Smith";
            Address = "1234 Some st";
            City = "Lake Jackson";
            State = "Texas";
            Zip = 77566;
            Email = "someone@thisplace.com";
            PhoneNumber = 12345678910;
            _orders = new List<Orders>()
            {
                new Orders()
            };
        }
    }
}
