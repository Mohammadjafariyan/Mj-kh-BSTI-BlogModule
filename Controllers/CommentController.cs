using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SignalRMVCChat.Models;
using SignalRMVCChat.Service;

namespace SignalRMVCChat.Controllers
{
        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class CommentController: Controller
    {
        private readonly CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public ActionResult Comment([FromBody] string text)
        {
            
            _commentService.Save(new Comment
            {
                Text = text
            });

            return Json(true);
        }
        
       
    }
}