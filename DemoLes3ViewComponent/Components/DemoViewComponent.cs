using DemoLes3ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

// todo 1. Create a DemoViewComponent.cs in folder Components/
namespace DemoLes3ViewComponent.Components
{
    public class DemoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() {
            return View(new ViewModelCurrentDateTime() {
                Message = $"{DateTime.Now:G}"
            });
        }
    }
}
