using Microsoft.AspNetCore.Mvc;
using VivesBlog.Ui.Mvc.Core;
using VivesBlog.Ui.Mvc.Models;

namespace VivesBlog.Ui.Mvc.Controllers
{
    public class BlogController : Controller
    {
        private readonly VivesBlogDbContext _dbContext;

        public BlogController(VivesBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var articles = _dbContext.Articles.ToList();
            return View(articles);
        }
        
    }
}