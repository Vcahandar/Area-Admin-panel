using EntytiFramework_Slider.Data;
using EntytiFramework_Slider.Models;
using EntytiFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntytiFramework_Slider.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public  async Task<IActionResult>  Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            IEnumerable<Blog> blogs = await _context.Blogs.Where(m=>!m.SoftDelete).ToListAsync();

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var res = nums.FirstOrDefault();
           


            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo,
                Blogs = blogs

            };
            return View(model);
        }


    }
}