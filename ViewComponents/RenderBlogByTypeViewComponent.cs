using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalRMVCChat.Models.weblog;

namespace AbstractLibrary.ViewComponents
{
    [ViewComponent]
    public class RenderBlogByTypeViewComponent : ViewComponent 
    {
        public async Task<IViewComponentResult> InvokeAsync(BlogType blogType)
        {
            return View(blogType);
        }
    }
}