using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Clase base que contiene los métodos de calcular área y perímetro
 */
public abstract class Figura {

    public Figura() {
    }

     /*
    * Atributo de tipo string que corresponde al nombre de la figura
    */
    public String NombreFigura;

    /*
    * Método declarado de cálculo de área que se hereda a las clases hijas
    */
    public abstract void CalcularArea();

    /*
    * Método declarado de cálculo de perímetro que se hereda a las clases hijas
    */
    public abstract void CalcularPerimetro();
}