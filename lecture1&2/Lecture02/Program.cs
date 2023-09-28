namespace Lectures {

    internal class Program {

        static void Main(string[] args) {
            Person person = new();
            ABetterPerson aBetterPerson = new();

            person.setFirstname("Fredrik");
            person.setLastname("Gaaso");
            aBetterPerson.Firstname = "Fredrik";
            aBetterPerson.LastName = "Gaaso";
            Console.WriteLine($"Hello, {person.getFirstname()} {person.getLastname()}");
            Console.WriteLine("Hello, " + aBetterPerson.Firstname + " " + aBetterPerson.LastName);
        }

        public class ABetterPerson {
            public string Firstname { get; set; }

            private string _lastname;
            public string LastName
            {
                get {
                    return _lastname.Trim();
                }
                set
                {
                    if (value.Length>=5) {
                        _lastname = value;
                    }
                    else {
                        _lastname = string.Empty;
                    }
                }
            }

            
            
        }

        public class Person {
            private string firstName;
            private string lastName;

            public string getFirstname() {

                return firstName;
            }

            public string getLastname() {

                return lastName;
            }

            public void setLastname(string lastName) {
                if (lastName.Length >= 5) {
                    this.lastName = lastName;
                }
            }

            public void setFirstname(string firstName) {
                if (firstName.Length >= 5) {
                    this.firstName = firstName;
                }
            }
        }
    }
}