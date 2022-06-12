using AbstractLibrary.Controller;
using SignalRMVCChat.Models.HelpDesk;


namespace BlogModule.Controllers
{
    //[AbstractLibrary.Installation.AnyRequestFilter]          
    public class LanguageController : CoreGenericController<Language, BigPardakht.Data.ApplicationDbContext>
    {
        public LanguageController(BigPardakht.Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}