using AbstractLibrary.Controller;
using Microsoft.AspNetCore.Mvc;
using SignalRMVCChat.Models.HelpDesk;


namespace BlogModule.Controllers
{
        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class CategoryController : CoreGenericController<Category,BigPardakht.Data.ApplicationDbContext>
    {
        public CategoryController(BigPardakht.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}