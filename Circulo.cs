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
   * M�todo que se encarga de pedir y asignar los valores pedidos al usuario a los atributos de la clase
   */
    public void PedirDatosCirculo() {
        Console.WriteLine("Radio del circulo");
        RadioCirculo = Convert.ToDouble(Console.ReadLine());
    }

    /*
    * M�todo que se encarga de mostrar al usuario el �rea de la figura
    */
    public void VisualizarResultadoCirculo() {
        Console.WriteLine("El �rea del c�rculo es "+AreaCirculo);
    }

   /*
   * M�todo heredado de la clase Figura, calcula el �rea de la figura
   */
    public override void CalcularArea()
    {
        AreaCirculo = Convert.ToDouble(Math.PI * Math.Pow(RadioCirculo, 2));
    }

    /*
    * M�todo heredado de la clase Figura, calcula el per�metro de la figura
    * y muestra al usuario el resultado al usuario
    */
    public override void CalcularPerimetro()
    {
        double perimetro = Convert.ToDouble(2 * Math.PI * RadioCirculo);
        Console.WriteLine("Per�metro " + perimetro);
    }
}