using System.Linq;
using AbstractLibrary.Controller;
using BigPardakht.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRMVCChat.Models.HelpDesk;


namespace BlogModule.Controllers
{
        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class ArticleController:CoreGenericController<Article,BigPardakht.Data.ApplicationDbContext>
    {
        public ArticleController(BigPardakht.Data.ApplicationDbContext context) : base(context)
        {
        }

    }
}