using System;
using System.ComponentModel.DataAnnotations;

public class ResultadoQuiz
{
    public int Id { get; set; }

    [Required]
    public string UserId { get; set; } // ID do usuário autenticado

    [Required]
    public string Nome { get; set; }

    [Required]
    public int Pontuacao { get; set; }

    public DateTime DataHora { get; set; } = DateTime.Now;
}
