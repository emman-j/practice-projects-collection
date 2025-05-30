using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest
{
    public partial class Model
    { 
        public interface IUserService
        {
            string UserName { get; set; }
            int UserId { get; set; }    
        }

        public class User : IUserService
        {
            public string UserName { get; set; } 
            public int UserId { get; set; } 
        } 
    } 
}
