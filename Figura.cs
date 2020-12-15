using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Clase base que contiene los m�todos de calcular �rea y per�metro
 */
public abstract class Figura {

    public Figura() {
    }

     /*
    * Atributo de tipo string que corresponde al nombre de la figura
    */
    public String NombreFigura;

    /*
    * M�todo declarado de c�lculo de �rea que se hereda a las clases hijas
    */
    public abstract void CalcularArea();

    /*
    * M�todo declarado de c�lculo de per�metro que se hereda a las clases hijas
    */
    public abstract void CalcularPerimetro();
}