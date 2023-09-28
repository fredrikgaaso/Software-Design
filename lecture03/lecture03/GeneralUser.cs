namespace lecture03; 

abstract public class GeneralUser : IContactable {

     protected string _firstName;
     protected string _lastName;

     public GeneralUser(string firstname, string lastName) {
          _firstName = firstname;
          _lastName = lastName;
     }
     public abstract void Contact();
}

