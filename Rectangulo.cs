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
    * Método que se encarga de pedir y asignar los valores pedidos al usuario a los atributos de la clase
    */
    public void PedirDatosRectangulo() {
        Console.WriteLine("Base");
        BaseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura");
        AlturaRectangulo = Convert.ToDouble(Console.ReadLine());
    }

    /*
     * Método que se encarga de mostrar al usuario el área de la figura
     */
    public void VisualizarResultadoRectangulo() {
        Console.WriteLine("El área del rectángulo es " + AreaRectangulo);
    }

    /*
   * Método heredado de la clase Figura, calcula el área de la figura
   */
    public override void CalcularArea()
    {
        AreaRectangulo = BaseRectangulo * AlturaRectangulo;
    }

    /*
    * Método heredado de la clase Figura, calcula el perímetro de la figura
    * y muestra al usuario el resultado al usuario
    */
    public override void CalcularPerimetro()
    {
        double perimetro = BaseRectangulo * 2 + AlturaRectangulo * 2;
        Console.WriteLine("Perímetro " + perimetro);
    }
}