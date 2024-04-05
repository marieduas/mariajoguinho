namespace mariajoguinho;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	void AtualizaPersonagem()
  {
	progressoFome.Progress=Atual.GetFome();
	progressoSede.Progress=Atual.GetSede();
    progressoAlegria.Progress=Atual.GetAlegria();
  }
void BotaoComidaFoiClicado(object sender, EventArgs args)
  {
	Atual.SetFome(Atual.GetFome()+0,1);
	AtualizaPersonagem(); 
  }
void BotaoAguaFoiCLicado(object sender, EventArgs args)
  {
    Atual.SetSede(Atual.GetSede()+0,1);
	AtualizaPersonagem();
  }
void BotaoBrinquedoFoiClicado(object sender, EventArgs args)
  {
	Atual.SetAlegria(Atual.GetAlegria()+0,1);
	AtualizaPersonagem();
  }  
void PassouTempo()
  {
	Atual.SetFome(Atual.GetFome()+0,1);
	Atual.SetSede(Atual.GetSede()+0,1);
    Atual.SetAlegria(Atual.GetAlegria()+0,1);
    AtualizaPersonagem();
  }  
}

