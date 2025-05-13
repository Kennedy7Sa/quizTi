using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using quizInformatica.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

public class RankingModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public RankingModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<ResultadoQuiz> Rank { get; set; }

    public async Task OnGetAsync()
    {
        Rank = await _context.ResultadosQuiz
            .OrderByDescending(r => r.Pontuacao)
            .ThenBy(r => r.DataHora)
            .Take(10)
            .ToListAsync();
    }
}
