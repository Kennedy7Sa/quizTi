using Microsoft.AspNetCore.Mvc.RazorPages;

public class ResultadoModel : PageModel
{
    public int Pontuacao { get; set; }

    public void OnGet()
    {
        if (TempData["Pontuacao"] != null)
        {
            Pontuacao = (int)TempData["Pontuacao"];
        }
    }
}
