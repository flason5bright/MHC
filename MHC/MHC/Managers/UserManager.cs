using MHC.DataContext;
using MHC.ViewModels;
using System.Linq;

namespace MHC.Managers
{
    public class UserManager
    {
        public static UserManager Instance = new UserManager();

        private UserManager()
        {
        }

        public bool Login(LoginViewModel login)
        {
            using (MHCContext dbContext = new MHCContext())
            {
                var user = dbContext.Users.FirstOrDefault(it => it.Name == login.UserName);
                if (user != null)
                    return true;
                return false;
            }
        }
    }
}