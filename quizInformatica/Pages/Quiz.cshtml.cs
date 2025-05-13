using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using quizInformatica.Data;

[Authorize]
public class QuizModel : PageModel
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public QuizModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [BindProperty]
    public string[] Respostas { get; set; } = new string[5];

    public async Task<IActionResult> OnPostAsync()
    {
        var gabarito = new string[]
        {
            "Unidade Central de Processamento",
            "Windows",
            "Unidade de Estado Sólido",
            "HTML",
            "Memória de Acesso Aleatório"
        };

        int pontuacao = 0;

        for (int i = 0; i < gabarito.Length; i++)
        {
            if (!string.IsNullOrWhiteSpace(Respostas[i]) &&
                Respostas[i].Trim().ToLower() == gabarito[i].Trim().ToLower())
            {
                pontuacao++;
            }
        }

        var usuario = await _userManager.GetUserAsync(User);

        var resultado = new ResultadoQuiz
        {
            UserId = usuario.Id,
            Nome = usuario.UserName,
            Pontuacao = pontuacao
        };

        _context.ResultadosQuiz.Add(resultado);
        await _context.SaveChangesAsync();

        TempData["Pontuacao"] = pontuacao;
        return RedirectToPage("Resultado");
    }
}
