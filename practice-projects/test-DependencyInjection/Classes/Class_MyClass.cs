using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DITest.Model;
using System.Windows.Forms;

namespace DITest
{ 
    public class MyClass
    { 
        private readonly Model.IUserService _user;
        private readonly Database _database;

        public MyClass(Model.IUserService user, Database database)
        {
            _user = user;
            _database = database;
        }

        public void DoSomething()
        {
            Console.WriteLine(_user.UserName);

            MessageBox.Show(Database.ConnectionString + "\n" + _user.UserName);
        }

    } 
    
}
