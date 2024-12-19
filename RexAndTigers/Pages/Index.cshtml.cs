using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RexAndTigers.Pages;

public class HomePage : PageModel
{
    private readonly ILogger<HomePage> _logger;

    public HomePage(ILogger<HomePage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    
}
