using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_PoppelProject.User
{
    public class Type
    {
        public enum UserType
        {
            MarketingClerk = 0,
            Customer = 1
        }
        public enum Permission
        {
            ALL = 0,
            AddProducts = 1,
            RemoveProducts  = 2,
            EditProducts

        }
        protected UserType userTypeVal;
        protected List<Permission> permissions;

        #region UserType properties 
        public UserType UserTypeVal
        {
            get
            {
                return userTypeVal;
            }
            set
            {
                userTypeVal = value;
            }
        }
        #endregion
    }
}
