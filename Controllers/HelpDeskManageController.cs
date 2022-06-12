using System.Linq;
using System.Threading.Tasks;
using AbstractLibrary.Controller;
using Microsoft.EntityFrameworkCore;
using SignalRMVCChat.Models.HelpDesk;


namespace BlogModule.Controllers
{
        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class HelpDeskManageController:CoreGenericController<HelpDesk,BigPardakht.Data.ApplicationDbContext>
    {
        public HelpDeskManageController(BigPardakht.Data.ApplicationDbContext context) : base(context)
        {
        }

        public override Task<IQueryable<HelpDesk>> Query(IQueryable<HelpDesk> query)
        {
            query = query.Include(s => s.Language);
            return base.Query(query);
        }
    }
}