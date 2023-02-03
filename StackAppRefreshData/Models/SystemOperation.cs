using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAppRefreshData.Models
{
    internal class SystemOperation
    {
        struct UserInfo
        {
            public string Login;
            public string Password;
            public string Name;
            public string Surname;

            public double Weight;
            public double Age;
        }

        void Check() {
            UserInfo user = new UserInfo();
            #region Наполнение
            user.Login = "Богатырь";
            user.Password = "Богатырь";
            user.Name = "Богатырь";
            user.Surname = "Богатырь";

            user.Weight = 20.0d;
            user.Age = 40.0d;
            #endregion

            double get = 0.0d;
            ProgrecessFruits(ref user, get);
        }
        

        void ProgrecessFruits(ref Fruits fruits, double data) { 
            
        }
    }
}
