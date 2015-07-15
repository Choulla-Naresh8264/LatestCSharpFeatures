namespace PartialInterface
{
    public partial interface IPerson
    {
        string LastName { get; set; }
    }

    public partial interface IPerson
    {
        string FirstName { get; set; }
    }
}