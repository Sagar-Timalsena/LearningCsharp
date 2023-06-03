using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class UserLog
    {
        //constructor Injection
        /* private readonly IUserInterface _userInterface;
         public UserLog(IUserInterface userInterface)
         {
             this._userInterface = userInterface;
         }*/

        //properties Injection(setter injection)
        private IUserInterface _userInterface;
        public IUserInterface UserInterface
        {
            /*get
            {
                return UserInterface;
            }*/
            set
            {
                this._userInterface = value;
            }
        }
        public void DisplayUser()
        {
            _userInterface.PrintUser();
            /*UserManagement userManagement = new UserManagement();
            StudentUser studentUser = new StudentUser();
            userManagement.PrintUser();
            Console.ReadLine();*/
        }
    }
}
