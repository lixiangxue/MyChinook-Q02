using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
#endregion 

namespace chinookSystem.DAL
{
    //This is an internal class for security reasons 
    //Access is restrictedto withi this class library project
    //Ihherits DbContext for Entity Framework, which requires
    // System.Data.Entity
    internal class ChinookContext : DbContext
    {
        // Pass the connection string name to the 
        // DbContext using :base()
        public ChinookContext() : base("ChinookDB")
            { }
    }
}
