namespace PV2.Boletos.Emitites2
{
    public class ScolarshipHolder
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int NumbersAssignment { get; set; }
        public string Campus { get; set; }
        public ScolarshipHolder()

        { }
    }

    public class Buyer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ScolarshipHolderName { get; set; }
        public Buyer()
        { }

    }
    public class Seller
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int TicketNumbers { get; set; }
        public Seller()
        { }

    }
    public class Winners
    {

        public string PrizesList { get; set; }
        public int WinningTickets { get; set; }
        public Winners()
        { }

    }
}

   