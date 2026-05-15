namespace TP02.Models;

public class SugeridorReceta{

    public string nombre {get; set;}
    public DateTime fechaNacimiento {get;set;}
    public string tipoComida {get; set;}
    public double presupuesto {get; set;}
    public int cantComensales {get; set;}

    public int CalcularEdad(DateTime fechaNacimiento)
    {
        int edad= (DateTime.Today - fechaNacimiento).Days / 365;
        return edad; 
    }

    public string DeterminarPlato(string tipoComida, double presupuesto)
    {
      string platoSugerido = "";
      if (tipoComida== "caliente" && presupuesto<3000){
        platoSugerido="Fideos con manteca";
      }
      else if(tipoComida== "caliente" && presupuesto>=3000 && presupuesto <= 7000)
      {
        platoSugerido="Arroz con verduras salteadas";
      }
      else if(tipoComida=="caliente" && presupuesto > 7000)
      {
        platoSugerido="Pollo al horno con guarnición";
      }
      else if(tipoComida=="frio"&& presupuesto<3000){
        platoSugerido="Ensalada simple";
      }
      else if(tipoComida=="frio" && presupuesto>=3000 && presupuesto <= 7000){
      platoSugerido="Ensalada completa con proteína";
      }
      else if(tipoComida=="frio" && presupuesto > 7000){
        platoSugerido="Tabla de fiambres y quesos";
      }
      return platoSugerido;
    }
  public double CalcularTiempo(string tipoComida, int cantComensales)
  {
    double tiempo = 0;
    if((tipoComida== "caliente" && cantComensales>=1 && cantComensales<=3) || (tipoComida=="frio" && cantComensales>=4 && cantComensales <=7))
    {
      tiempo = 20;
    }
    else if((tipoComida=="caliente" && cantComensales>=4 && cantComensales <=7) || (tipoComida=="frio" && cantComensales>=8)){
      tiempo = 40;
    }
    else if(tipoComida=="caliente" && cantComensales>=8){
      tiempo = 80;
    }
    else if(tipoComida=="frio" && cantComensales>=1 && cantComensales<=3){
      tiempo=10;
    }
    return tiempo;
  }

  public string DeterminarDificultad(double presupuesto, int cantComensales)
  {
    string dificultad ="";
    if(presupuesto<3000 && cantComensales>=1 && cantComensales<=3){
      dificultad="Principiante";
    }
    else if(presupuesto<3000 && cantComensales>=4 && cantComensales <=7){
      dificultad="Intermedio";
    }
    else if(presupuesto>=3000 && presupuesto <= 7000 && cantComensales>=1 && cantComensales<=3){
      dificultad="Intermedio";
    }
    else if(presupuesto>=3000 && presupuesto <= 7000 && cantComensales>=4 && cantComensales <=7){
      dificultad="Intermedio";
    }
    else if(presupuesto>7000 && cantComensales >= 1 && cantComensales <=7){
      dificultad="Intermedio";
    }
    else if(presupuesto>7000 && cantComensales >=8)
    {
      dificultad="Avanzado";
    }
    return dificultad;
  }

}