using BigPardakht.Data;
using BigPardakht.Repository;
using Microsoft.AspNetCore.Http;
using SignalRMVCChat.Models.weblog;


namespace WeblogModule.Repository
{
    public class BlogRepository:AbstractRepository<Blog,BigPardakht.Data.ApplicationDbContext>
    {
        public BlogRepository(ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {
        }
    }
}