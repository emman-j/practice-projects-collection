using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DITest
{
    public partial class Presenter
    {
        public class User : INotifyPropertyChanged
        {
            //private Model.User _user;
            private Model.IUserService _userService;

            public User(Model.IUserService userService)
            {
                _userService = userService;
            }
             
            public string UserName
            {
                get { return _userService.UserName; }
                set
                {
                    if (_userService.UserName != value)
                    {
                        _userService.UserName = value;
                        NotifyPropertyChanged();
                    }
                }
            }
            public int UserId
            {
                get { return _userService.UserId; }
                set
                {
                    if (_userService.UserId != value)
                    {
                        _userService.UserId = value;
                        NotifyPropertyChanged();
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
