namespace pou;

public class panda1
{
    public  double  comida;

    public  double  agua;

    public  double  alegria; 

    public  string  nomedaFoto;


    public panda1()

  {
    comida=0;
    agua=0;
    alegria=0;
    nomedaFoto="..";
  }
  public string GetnomedaFoto()
  {
    return nomedaFoto;
  }  

  public void setcomida ( double  c)
  {
    if(agua>=0 && c <=1)
      comida = c;
    else if (c > 1) 
      comida = 1; 
}
  public void setagua ( double  a)
{
    if(a>=0 && a <= 1)
         
            agua = a;
        else if (a > 1)
            agua = 1;
}
  
   
    public void setalegria ( double  d)
   {
       if(d>=0 && d <= 1)
          alegria = d;
       else if (d > 1)
          alegria = 1;
   }
  

}