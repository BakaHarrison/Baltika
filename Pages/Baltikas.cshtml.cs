using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using testWeb.Model;
using testWeb.Repository;

namespace WebApplication1.Pages
{
    public class BaltikasModel : PageModel
    {

        public BaltikasModel(IBaltika userRepository)
        {
            _baltikaRepository = userRepository;
        }
        private IBaltika _baltikaRepository;
        public List<Baltika> Baltikas { get; set; }
        public IActionResult OnGet()
        {
            Baltikas = _baltikaRepository.GetAll();
            return Page();
        }

    }
}
