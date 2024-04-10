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
    comida=F;
}

public double GetComida()
{
    return comida;
}

 
public void SetAgua(double S)
{
    agua = S;
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
    alegria=B;
}

}