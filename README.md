# 🧠 Quiz de Informática

Um sistema web simples desenvolvido em ASP.NET Core Razor Pages com autenticação individual e banco de dados SQLite. O objetivo do projeto é aplicar conceitos de desenvolvimento web e banco de dados criando um quiz de 5 perguntas sobre informática com registro de pontuação por usuário autenticado.

---

## 🚀 Funcionalidades

- ✅ Cadastro e login de usuários (ASP.NET Identity)
- ✅ Quiz com 5 perguntas de múltipla escolha
- ✅ Armazenamento da pontuação no banco de dados SQLite
- ✅ Interface moderna e responsiva com Bootstrap 5
  

---

## 🎮 Como Funciona o Jogo

1. O usuário deve estar logado.
2. Cada pergunta possui 4 alternativas.
3. Cada resposta correta vale 1 ponto.
4. Ao finalizar, a pontuação é salva junto ao nome do jogador logado.

---

## 🧱 Tecnologias Utilizadas

- ASP.NET Core 8.0 (Razor Pages)
- C#
- Entity Framework Core com SQLite
- ASP.NET Core Identity
- Bootstrap 5
- HTML5, CSS3

---

## 📦 Estrutura do Projeto

```bash
├── Pages/
│   ├── Index.cshtml         # Página inicial com explicação e imagem
│   ├── Quiz.cshtml          # Página com as 5 perguntas do quiz
│   └── Account/             # Páginas de login, cadastro, logout (Identity)
├── Models/
│   └── Resultado.cs         # Modelo de dados para armazenar pontuação
├── Data/
│   └── ApplicationDbContext.cs  # Contexto do banco de dados
├── wwwroot/
│   ├── css/site.css         # Estilos customizados
│   └── imagens/             # Imagem de fundo ou decorativa
