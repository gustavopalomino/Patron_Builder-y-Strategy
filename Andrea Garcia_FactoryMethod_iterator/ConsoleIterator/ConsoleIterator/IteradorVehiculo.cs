using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator
{
    public class IteradorVehiculo: IEnumerator
    {
//----------------------------------------------------------------------------------
        //nota:
        //.NET ofrecen una interfaz estándar de la cual es aconsejable que hereden 
        //los iteradores que decidamos implementar.Esta interfaz es IEnumerator.

         //IEnumerator no posee un método QuedanElementos(). Sin embargo, esta 
         //funcionalidad está cubierta por el método MoveNext(), que en lugar 
         //de devolver una referencia al elemento siguiente, comprueba si existen 
         //elementos y devuelve el resultado de la consulta. Además, en caso 
         //afirmativo, incrementará el índice en una unidad, permitiendo al método 
         //Current() acceder al siguiente elemento.

//--------------------------------------------------------------------------------

   // Referencia al listado completo
    private ArrayList listaElementos;
 
    // Almacenaremos el índice en el que se encuentra el iterador
   // el cual empieza en la posicion anterios al primero de la estructura
    private int posicionActual = -1;
 
    // El constructor inyectará el ArrayList en el objeto
    public IteradorVehiculo(ArrayList listaElementos)
    {
        this.listaElementos = listaElementos;
    }
 
 

    //------------metodos que hereda de la interfaz IEnumerator--------------- 

    public void Reset()
    {
        this.posicionActual = -1;
    }

    // Devuelve el elemento actual
    public Vehiculo Current
    {
        get
        {
            // Si no existen elementos, devolveremos null.
            // Si el indice actual es mayor que el mayor indice aceptable, devolveremos null.
            // Si el indice actual es -1, devolveremos null.
            if ((this.listaElementos == null) ||
                (this.listaElementos.Count == 0) ||
                (posicionActual > this.listaElementos.Count - 1) ||
                (this.posicionActual < 0))
                return default(Vehiculo);

            // Devolvemos el elemento correspondiente al elemento actual
            else
                return (Vehiculo)this.listaElementos[posicionActual];
        }
    }

    object IEnumerator.Current
    {
        get { return Current; }
    }

    // La función ElementoSiguiente() de IEnumerable, a diferencia del ejemplo anterior, no devuelve una
    // referencia al siguiente elemento, sino que detecta si existe otro elemento (lo que en la implementación
    // anterior realizaba QuedanElementos()) y en caso afirmativo, incrementa el índice, apuntando al siguiente
    // elemento, que será recuperado mediante Current.
    public bool MoveNext()
    {
        bool quedanElementos = (posicionActual + 1 <= this.listaElementos.Count - 1);
        if (quedanElementos)
            posicionActual++;

        return quedanElementos;
    }

    public void Dispose()
    {
        // Este método se implementará en caso de utilizar recursos no gestionados.
        // En ese caso, aquí se liberarán esos recursos antes de destruir el objeto.
        return;
    }

    }
}
