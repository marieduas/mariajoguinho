namespace pou;

public class Principal 
{
    public  double  comida;

    public  double  agua;

    public  double  alegria; 

    public  string  nomedaFoto;


  public string GetnomedaFoto()
  {
    return nomedaFoto;
  }  

  public void SetComida(double F)
{      
   if ( F > 0 && F < 1)
    comida = F;
  else if (F <= 0)
  {
    comida = 0;
  }
  else 
    comida = 1;       
}

public double GetComida()
{
    return comida;
}

 
public void SetAgua(double S)
{
  if ( S > 0 && S < 1)
    agua = S;
  else if (S <= 0)
  {
    agua = 0;
  }
  else 
    agua = 1;
}

public double GetAgua()
{
    return agua;
}



public double GetAlegria()
  {
    return alegria;
  }

public void SetAlegria(double B)
{
    if ( B > 0 && B < 1)
    alegria = B;
  else if (B <= 0)
  {
    alegria = 0;
  }
  else 
    alegria = 1;
}

}