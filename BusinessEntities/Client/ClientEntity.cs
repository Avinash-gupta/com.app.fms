namespace BusinessEntities
{
    public class ClientEntity
    {
        public ClientInformationEntity ClientInformation { get; set; }
        public BillingDetailsEntity BillingDetails { get; set; }
    }

    public class ClientInformationEntity
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Segment { get; set; }
        public string ContactPerson { get; set; }
        public string PersonDesignation { get; set; }
        public int PhoneNos { get; set; }
        public int LandLineNo { get; set; }
        public string EmailId { get; set; }
        public int FaxNo { get; set; }
        public bool IsActive { get; set; }
    }

    public class BillingDetailsEntity
    {
        public int Id { get; set; }
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
        public string Paysheet { get; set; }
        public string Location { get; set; }
    }
}
