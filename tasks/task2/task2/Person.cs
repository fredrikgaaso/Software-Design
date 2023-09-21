namespace task2; 

public class Person {
    
    private string _firstName;
    private string _lastName;

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
    public string FirstName {
        get
        {
            return _firstName;
        }
        set
        { 
            _firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            _lastName = value.Trim();
        }
    }
}