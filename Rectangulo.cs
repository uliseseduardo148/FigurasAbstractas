using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rectangulo : Figura {

    public Rectangulo() {
    }

    public double BaseRectangulo;
    public double AlturaRectangulo;
    public double AreaRectangulo;

    /*
    * M�todo que se encarga de pedir y asignar los valores pedidos al usuario a los atributos de la clase
    */
    public void PedirDatosRectangulo() {
        Console.WriteLine("Base");
        BaseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura");
        AlturaRectangulo = Convert.ToDouble(Console.ReadLine());
    }

    /*
     * M�todo que se encarga de mostrar al usuario el �rea de la figura
     */
    public void VisualizarResultadoRectangulo() {
        Console.WriteLine("El �rea del rect�ngulo es " + AreaRectangulo);
    }

    /*
   * M�todo heredado de la clase Figura, calcula el �rea de la figura
   */
    public override void CalcularArea()
    {
        AreaRectangulo = BaseRectangulo * AlturaRectangulo;
    }

    /*
    * M�todo heredado de la clase Figura, calcula el per�metro de la figura
    * y muestra al usuario el resultado al usuario
    */
    public override void CalcularPerimetro()
    {
        double perimetro = BaseRectangulo * 2 + AlturaRectangulo * 2;
        Console.WriteLine("Per�metro " + perimetro);
    }
}