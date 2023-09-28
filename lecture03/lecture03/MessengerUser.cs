namespace lecture03; 

public class MessengerUser : GeneralUser {
    
    public MessengerUser(string firstName, string lastName) : base(firstName, lastName) {
        
    }
    public override void Contact() {
        Console.WriteLine("Sending message by messenger");
    }

    public override string ToString() {
        return $"{_firstName} {_lastName}";
    }
}