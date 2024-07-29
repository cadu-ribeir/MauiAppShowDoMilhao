using MauiAppShowDoMilhao.Properties.Models;

namespace MauiAppShowDoMilhao
{

    List<Pergunta> perguntas_faceis = new()
    {
        new Pergunta {
            Id = 1,
            Enunciado = "Qual é o nome dado ao estado da água"} 
    }
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
