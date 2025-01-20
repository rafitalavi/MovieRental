namespace Moviewala.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } /* Connection between the two classes */
        public byte MembershipTypeId { get; set; } /* Foreign key from the MembershipType class */
    }
}
