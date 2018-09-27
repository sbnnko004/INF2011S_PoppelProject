using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011S_PoppelProject.User
{
    public class MarketingClerk: Type
    {
        #region Constructor
        public MarketingClerk() : base()
        {
            UserTypeVal = UserType.MarketingClerk;
            // add permissions here
        }
        #endregion
    }
}
