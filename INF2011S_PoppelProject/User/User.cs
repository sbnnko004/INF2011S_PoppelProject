using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_PoppelProject.User
{
    public class User: Person
    {
        private string userID;
        public Type userType;

        #region Properties
        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }
        #endregion
        #region Constructors
        //Employee will always be created in a specific role -- IF NO role is assigned  
        //Role will just be a generic default where role type is 0 and description is: "No Role"
        public User(Type.UserType userValue)
        {
            switch (userValue)
            {
                case Type.UserType.Customer:
                    userType = new Customer();
                    break;
                case Type.UserType.MarketingClerk:
                    userType = new MarketingClerk();
                    break;
            }
        }
        #endregion

        //***One can add a ToString method here to override the ToString method of a Person object
        #region override
        public override string ToString()
        {
            return this.empID + ":    " + this.Name;
        }
        #endregion
    }

}
