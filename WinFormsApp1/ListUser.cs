using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ListUser
    {
        private static ListUser instance ;
        private List <User> listAccountUsers ;

        internal static ListUser Instance
        { get
            {
                if(instance==null)
                    instance = new ListUser();
                return instance;
            }
                
          set => instance = value;
        }
        internal List<User> ListAccountUsers { get => listAccountUsers; set => listAccountUsers = value; }

        private ListUser()
        {
            ListAccountUsers = new List<User>();
            ListAccountUsers.Add(new User("hoangtv", "30112003"));
            ListAccountUsers.Add(new User("duypm", "08072003"));
            ListAccountUsers.Add(new User("quanghuy", "01022003"));
            ListAccountUsers.Add(new User("nguyenhong", "27012003"));
            ListAccountUsers.Add(new User("haomb", "15082003"));
        }
    }
}
