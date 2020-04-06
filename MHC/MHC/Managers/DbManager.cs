using MHC.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MHC.Managers
{
    public class DbManager
    {
        public static MHCContext DbContext = new MHCContext();
    }
}