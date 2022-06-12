using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SignalRMVCChat.Service;
using SignalRMVCChat.Service.HelpDesk;
using SignalRMVCChat.Service.HelpDesk.Article;
using SignalRMVCChat.Service.HelpDesk.Language;

using WeblogModule.Repository;

namespace WeblogModule
{
    public class IcConfig
    {
        
        public  static void ConfigureServices(IServiceCollection services)
        {
            /*services.AddDbContext<BigPardakht.Data.ApplicationDbContext>(options =>
                {
                    options.UseInMemoryDatabase("Test2");
                    /*if (MyGlobal.IsAttached)
                    {
                        options.UseInMemoryDatabase("Test");
                    }
                    else
                    {
                        options.UseSqlite(
                            Configuration.GetConnectionString("DefaultConnection"));
                    }#1#
                }
            );*/
            
            services.AddTransient<BlogRepository>();
            services.AddTransient<CommentService>();
            services.AddTransient<CategoryImageService>();
            services.AddTransient<CategoryService>();
            services.AddTransient<LanguageService>();
            services.AddTransient<ArticleService>();
            services.AddTransient<HelpDeskService>();
            
            
        }
    }
}