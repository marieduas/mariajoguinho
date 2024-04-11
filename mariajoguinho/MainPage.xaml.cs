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

    var timer =
   Application.Current.Dispatcher.
   CreateTimer();
    timer.Interval =
   TimeSpan.FromSeconds(1);
    timer.Tick += (s,e) =>
    PassouTempo();
    timer.Start();   
    
    atual=pandinha;
   
    Pandolino.Source = atual.GetnomedaFoto();

    ProgressoFome.Progress = atual.GetComida();  
    ProgressoSede.Progress = atual.GetAgua();
    ProgressoAlegria.Progress = atual.GetAlegria();
  }


  void PassouTempo()
  {
    atual.SetComida(atual.GetComida() - 0.1);
     atual.SetAgua(atual.GetAgua() - 0.1);
     atual.SetAlegria(atual.GetAlegria() - 0.1);
     PassouTempo();
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
     Pandolino.Source = atual.GetnomedaFoto();
  }

  void Atualizaobicho()
  {
    ProgressoFome.Progress = atual.GetComida();  
    ProgressoSede.Progress = atual.GetAgua();
    ProgressoAlegria.Progress = atual.GetAlegria();
  }

  void Aumentacomida(object Sender, EventArgs args)
  {
    atual.SetComida(atual.GetComida() + 0.1);
    Atualizaobicho();
  }

  void Aumentaagua(object Sender, EventArgs args)
  {
    atual.SetAgua(atual.GetAgua() + 0.1);
    Atualizaobicho();
  }

  void Aumentaalegria(object Sender, EventArgs args)
  {
    atual.SetAlegria(atual.GetAlegria() + 0.1);
    Atualizaobicho();
  }
  
  
}