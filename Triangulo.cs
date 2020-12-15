using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Triangulo : Figura {

    public Triangulo() {
    }

    public double BaseTriangulo;
    public double AlturaTriangulo;
    public double AreaTriangulo;

    /*
     * Método que se encarga de pedir y asignar los valores pedidos al usuario a los atributos de la clase
     */
    public void PedirDatosTriangulo() {
        Console.WriteLine("Base");
        BaseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura");
        AlturaTriangulo = Convert.ToDouble(Console.ReadLine());
    }

    /*
     * Método que se encarga de mostrar al usuario el área del triángulo
     */
    public void VisualizarResultadoTriangulo() {
        Console.WriteLine("El área  es " + AreaTriangulo);
    }

    /*
    * Método heredado de la clase Figura, calcula el área del triángulo
    */
    public override void CalcularArea()
    {
        AreaTriangulo = (BaseTriangulo * AlturaTriangulo) / 2;
    }

    /*
    * Método heredado de la clase Figura, calcula el perímetro de la figura en base al Teorema de Pitágoras
    * y muestra al usuario el resultado al usuario
    */
    public override void CalcularPerimetro()
    {
        double perimetro = BaseTriangulo + AlturaTriangulo + Math.Sqrt(Math.Pow(BaseTriangulo, 2) + Math.Pow(AlturaTriangulo, 2));
        Console.WriteLine("El perímetro  es " + perimetro);
    }
}