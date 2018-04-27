using Microsoft.AspNet.Identity.EntityFramework;

namespace IntellectBit.Treeshrew.MyHomeService
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}