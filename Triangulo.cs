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
     * M�todo que se encarga de pedir y asignar los valores pedidos al usuario a los atributos de la clase
     */
    public void PedirDatosTriangulo() {
        Console.WriteLine("Base");
        BaseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Altura");
        AlturaTriangulo = Convert.ToDouble(Console.ReadLine());
    }

    /*
     * M�todo que se encarga de mostrar al usuario el �rea del tri�ngulo
     */
    public void VisualizarResultadoTriangulo() {
        Console.WriteLine("El �rea  es " + AreaTriangulo);
    }

    /*
    * M�todo heredado de la clase Figura, calcula el �rea del tri�ngulo
    */
    public override void CalcularArea()
    {
        AreaTriangulo = (BaseTriangulo * AlturaTriangulo) / 2;
    }

    /*
    * M�todo heredado de la clase Figura, calcula el per�metro de la figura en base al Teorema de Pit�goras
    * y muestra al usuario el resultado al usuario
    */
    public override void CalcularPerimetro()
    {
        double perimetro = BaseTriangulo + AlturaTriangulo + Math.Sqrt(Math.Pow(BaseTriangulo, 2) + Math.Pow(AlturaTriangulo, 2));
        Console.WriteLine("El per�metro  es " + perimetro);
    }
}