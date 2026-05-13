namespace TP02.Models;

public class SugeridorReceta{

    public string Nombre {get; set;}
    public DateTime fechaNacimiento {get;set;}
    public string tipoComida {get; set;}
    public double presupuesto {get; set;}
    public int cantComensales {get; set;}

    public int calcularEdad(DateTime fechaNacimiento)
    {
        int edad= DateTime.Today - fechaNacimiento;
        return edad; 
    }

    public string determinarPlato(string tipoComida, double presupuesto)
    {
      string platoSugerido;
      if (tipoComida== "caliente" && presupuesto<3000){
        platoSugerido="Fideos con manteca";
      }
      else if(tipoComida== "caliente" && presupuesto>=3000 && presupuesto <= 7000)
      {
        platoSugerido="Arroz con verduras salteadas";
      }
      else if(tipoComida=="caliente" && presupuesto < 7000)
      {
        platoSugerido="Pollo al horno con guarnición";
      }
      else if(tipoComida=="frio"&& presupuesto<3000){
        platoSugerido="Ensalada simple";
      }
      else if(tipoComida=="frio" && presupuesto>=3000 && presupuesto <= 7000){
      platoSugerido="Ensalada completa con proteína";
      }
      else if(tipoComida=="frio" && presupuesto < 7000){
        platoSugerido="Tabla de fiambres y quesos";
      }
    }


}