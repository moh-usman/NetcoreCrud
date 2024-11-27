using Microsoft.EntityFrameworkCore;

namespace Git_Web_Netcoremvc_Crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
