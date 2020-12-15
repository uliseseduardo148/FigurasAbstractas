using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Circulo : Figura  {

    public Circulo() {
    }

    public double RadioCirculo;
    public double AreaCirculo;

    /*
   * Método que se encarga de pedir y asignar los valores pedidos al usuario a los atributos de la clase
   */
    public void PedirDatosCirculo() {
        Console.WriteLine("Radio del circulo");
        RadioCirculo = Convert.ToDouble(Console.ReadLine());
    }

    /*
    * Método que se encarga de mostrar al usuario el área de la figura
    */
    public void VisualizarResultadoCirculo() {
        Console.WriteLine("El área del círculo es "+AreaCirculo);
    }

   /*
   * Método heredado de la clase Figura, calcula el área de la figura
   */
    public override void CalcularArea()
    {
        AreaCirculo = Convert.ToDouble(Math.PI * Math.Pow(RadioCirculo, 2));
    }

    /*
    * Método heredado de la clase Figura, calcula el perímetro de la figura
    * y muestra al usuario el resultado al usuario
    */
    public override void CalcularPerimetro()
    {
        double perimetro = Convert.ToDouble(2 * Math.PI * RadioCirculo);
        Console.WriteLine("Perímetro " + perimetro);
    }
}