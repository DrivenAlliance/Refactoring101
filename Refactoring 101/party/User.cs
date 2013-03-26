namespace Refactoring_101.party
{
    internal class User
    {
        private readonly Person _person;
        private string _password;
        private string _userName;

        public User(string userName,
                    string password,
                    Person person)
        {
            _person = person;
            _userName = userName;
            _password = password;
        }

        private void UpdateDetails(string userName,
                                   string password,
                                   string name,
                                   string surname,
                                   string phoneNumber)
        {
            // Smells below: Long Method and Feature Envy
            // Use Extract Method and Move Method to clean it up
            _userName = userName;
            _password = password;
            _person.Name = name;
            _person.Surname = surname;
            _person.PhoneNumber = phoneNumber;
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Surname { get; set; }
    }
}