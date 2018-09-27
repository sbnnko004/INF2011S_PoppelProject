using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_PoppelProject.User
{
    public class Customer: Type
    {
        #region Constructor
        public Customer() : base()
        {
            UserTypeVal = UserType.Customer;
            // add permissions here
        }
        #endregion
    }
}
