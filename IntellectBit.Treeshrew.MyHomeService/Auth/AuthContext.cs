using Microsoft.AspNet.Identity.EntityFramework;

namespace IntellectBit.Treeshrew.MyHomeService.Auth
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}