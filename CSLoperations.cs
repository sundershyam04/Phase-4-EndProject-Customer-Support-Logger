using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CSLoperations
    {

        csldbEntities context;

        public CSLoperations()
        {
            context = new csldbEntities();
        }

        public bool ValidateUser(int u, string email,string pw)
        {

            var found = context.UserInfoes.ToList().Find(w => ((w.UserId == u) && (w.Email == email) && (w.Password == pw)));

            return found != null;
        }

        public bool Registerlog(CustLogInfo c)
        {
            try
            {
                var done = context.CustLogInfoes.Add(c);
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
