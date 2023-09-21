

using lecture03;

List<IContactable> users = new();
IContactable Contactable;

Contactable = new EmailUser("Lars", "something@something.com", "Berrum");
users.Add(Contactable);

Contactable = new MessengerUser("Fredrik", "Gaaso");
users.Add(Contactable);

//Contactable = new SnapchatUser();
//users.Add(Contactable);

//Contactable = new RemoteService();
//users.Add(Contactable);

foreach (IContactable item in users) {
    if (item.GetType().Name == "EmailUser") {
        Console.WriteLine(item);
        Console.WriteLine(item.GetType().Name); 
        item.Contact();
    }
    else {
        Console.WriteLine(item);
        Console.WriteLine(item.GetType().Name); 
        item.Contact();
    }
    
}
