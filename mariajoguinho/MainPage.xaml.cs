using pou;

namespace mariajoguinho;

public partial class MainPage : ContentPage
{
  Principal atual;
  Panda pandinha = new Panda();

  Preguica calva = new Preguica();

  Coala coala = new Coala();

  

  public MainPage()
  {
    InitializeComponent();
    
    atual=calva;
   
    atual.Source = atual.GetnomedaFoto();

    ProgressoFome.Progress = atual.GetComida();  
    ProgressoSede.Progress = atual.GetAgua();
    ProgressoAlegria.Progress = atual.GetAlegria();
  }

  public void TrocaPersonagem(object Sender, EventArgs args)
  {
    if (atual == calva)
    {
       atual = pandinha;
    }
    else if(atual == pandinha)
    {
      atual = coala;
    }
    else 
     atual = calva;
  }
}