using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Login1.Data
{
    public class ChatDbContext : IdentityDbContext
    {
        public ChatDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
