namespace PartialInterface
{
    public class Person : IPerson
    {
        public string FirstName
        {
            get;set;
        }= "Jalpesh";

        public string LastName
        {
            get;set;
        }="Vadgama";
    }
}