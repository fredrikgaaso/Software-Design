namespace lecture03; 

public class EmailUser : GeneralUser {

    private string _emailAddress;
    public EmailUser(string firstName, string emailAddress, string lastName = "unknown") : base(firstName, lastName) {
        _emailAddress = emailAddress;
    }
    public override void Contact() {
        Console.WriteLine("Sending an email to generalUser");

    }

    public override string ToString() {
        return $"{_firstName} {_lastName} | {_emailAddress}";
    }

}