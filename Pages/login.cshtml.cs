using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fitnes_studio.Pages;
    public class loginModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

    public loginModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        }
    

    public void OnGet()
    {

    }
}