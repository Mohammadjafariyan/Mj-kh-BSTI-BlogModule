using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalRMVCChat.Models;
using SignalRMVCChat.Service;
using SignalRMVCChat.Service.HelpDesk;
using SignalRMVCChat.Service.HelpDesk.Article;

namespace BlogModule.Controllers
{
        //[AbstractLibrary.Installation.AnyRequestFilter]          
                                                                    public class HelpDeskController:Controller
    {

        private HelpDeskService HelpDeskService;
        private readonly CommentService _commentService;
        private readonly ArticleService _articleService;

        public HelpDeskController(HelpDeskService helpDeskService,CommentService commentService,
            ArticleService articleService)
        {
            HelpDeskService = helpDeskService;
            _commentService = commentService;
            _articleService = articleService;
        }
        
        
        

        [HttpGet()]
        public async Task<ActionResult> Index( string lang=null,
            string searchTerm=null)
        {

            
            TempData["lang"] = lang;


            var helpDeskHomeView = await HelpDeskService.GetHelpDeskHome( lang, searchTerm);

            /*ViewBag.helpDesk = helpDeskHomeView.HelpDesk;
            ViewBag.Languages = helpDeskHomeView.Languages;*/

            return View("Index", helpDeskHomeView);
        }


        [HttpPost]
        public async Task<ActionResult> SendFeedback
            (string text,  string lang,string title,bool IsHelpful,
            string customerToken=null)
        {
            
            var article=  await HelpDeskService.GetHelpDeskArticle(title, lang,null);


        
            if (article.Article.Comments==null)
            {
                article.Article.Comments=new List<Comment>();
            }
            



            _articleService.Save(article.Article);


            _commentService.Save(new Comment
            {
                ArticleId = article.Article.Id,
                Text = text,
                IsHelpful = IsHelpful,
                CreationDateTime=DateTime.Now,
                //CustomerId = CurrentRequest?.customerId
            });

            return new StatusCodeResult(200);
        }
        
        [HttpGet()]
        public  async Task<ActionResult> Article(string title, string lang)
        {
            
            TempData["lang"] = lang;
            
            
            var article=  await HelpDeskService.GetHelpDeskArticle(title, lang,
                Request);

            ViewBag.helpDesk = article.HelpDesk;
            ViewBag.Languages = article.Languages;

            return View("Article",article);
        }


        [HttpGet()]
        public async Task<ActionResult> Detail(string categoryTitle,  string lang)
        {
            
            TempData["lang"] = lang;


            var CategoryArticlesViewModel = await HelpDeskService.GetHelpDeskArticleByCategoryTitle(categoryTitle,  lang);

            ViewBag.helpDesk = CategoryArticlesViewModel.HelpDesk;
            ViewBag.Languages = CategoryArticlesViewModel.Languages;


            return View("Detail", CategoryArticlesViewModel);
        }



        [HttpGet()]
        public async Task<ActionResult> Search(  string lang,string searchTerm)
        {
            
            TempData["lang"] = lang;


            var CategoryArticlesViewModel = await HelpDeskService.Search(  lang, searchTerm);

            ViewBag.helpDesk = CategoryArticlesViewModel.HelpDesk;
            ViewBag.Languages = CategoryArticlesViewModel.Languages;


            return View("Detail", CategoryArticlesViewModel);
        }

        [HttpGet()]
        public async Task<ActionResult> CategoryImage(int id)
        {
            
            var content=  await HelpDeskService.GetHelpDeskImage(id);

            if (content==null)
            {
                return
                    new EmptyResult(); //base.File(System.IO.File.ReadAllBytes(Server.MapPath("~/Content/HelpImages/article.png")), "image/png");;

            }

            try
            {

                string base64 = content.Split(',')[1];
            
                byte[] bytes = Convert.FromBase64String(base64);


                return base.File(bytes, "image/jpeg");;
            }
            catch (Exception e)
            {
                return
                    new EmptyResult(); //base.File(System.IO.File.ReadAllBytes(Server.MapPath("~/Content/HelpImages/article.png")), "image/png");;

            }
        }
        
        
    }
}