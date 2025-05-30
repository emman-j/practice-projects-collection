using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp3
{
    public class PersonManager
    {
        private List<Person> people; //create list of People

        //Constructor
        public PersonManager()
        {
            people = new List<Person>();
        }

        //Method to add Person
        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public List<Person> GetAllPeople()
        {
            return people;

        }

        public List<Person> Search(string searchTerm)
        {
            string searchTermLower = searchTerm.ToLower();

            List<Person> searchResult = people.FindAll(
                person =>
                        person.Fname.ToLower().Contains(searchTermLower) ||
                        person.Lname.ToLower().Contains(searchTermLower)
                );
            return searchResult;
        }

        public void PrintSearchResults(List<Person> searchResult)
        {
            StringBuilder sBuilder = new StringBuilder();

            foreach (var person in searchResult)
            {
                sBuilder.AppendLine($"Firstname: {person.Fname}, Lastname: {person.Lname}");
            }

            // Show the message using a MessageBox
            MessageBox.Show(sBuilder.ToString(), "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
