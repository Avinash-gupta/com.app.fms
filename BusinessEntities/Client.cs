namespace BusinessEntities
{
    public class Client
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Segment { get; set; }
        public string ContactPerson { get; set; }
        public string PersonDesignation { get; set; }
        public int PhoneNos { get; set; }
        public int LandLineNo { get; set; }
        public string EmailId { get; set; }
        public int FaxNo { get; set; }
        public Billingaddress BillingAddress { get; set; }
    }

    public class Billingaddress
    {
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string LineThree { get; set; }
        public string LineFour { get; set; }
        public string LineFive { get; set; }
        public string LineSix { get; set; }
        public string Description { get; set; }
        public string SubUnit { get; set; }
        public string MainUnit { get; set; }
        public string Invoice { get; set; }
        public string PaySheet { get; set; }
        public string Location { get; set; }
    }
}
