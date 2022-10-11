using System;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numeroo = 255;
            // byte = solo cabe numeros del 0 al 255. Byte esta orientado a aguradar solo un byte. Es más flexible, más rapido y guarda menos memoria
            sbyte num = -128;
            // sbyte es su nemeci. Me permite tener numeros negativos. Va del -128 al 127
            int numm = -128;
            // El int almacena 4 bytes. Llega a un rango muchisimo mayor cerca de 2147millones. Positivos y negativos
            uint nummm = 128;
            // Permite solo numeros negativos
            long nuum = 128;
            // Es un int mayor. Es el entero más largo. Cerca de trillones de datos. Positivos y negativos. Son 8 bytes. 
            ulong nnum = 128;
            // Solo permite numeros positivos.
            float nuuum = 189.1f;
            // Es un dato de tipo flotante. Al final se le debe poner una f para que te lo tome como dato de tipo flotante. Tiene 4 bytes.
            double nume = 189.1d;
            // Es un dato de tipo doble. Al final se le debe poner una d para que te lo tome como dato de tipo double. Tiene 8 bytes.
            decimal numer = 189.1m;
            // Es un dato de tipo decimal. Al final se le debe poner una m para que te lo tome como dato de tipo decimal. Tiene mayor alcance. Tiene 16 bytes.
            char caracter = 'A';
            // Hay que ponerlo con comillas simples porque sino lo reconoce como string y maraca error. Solo permite dos bytes, por ende solo se puede poner una letra.
            string texto = "Hola como estas";
            // Es un dato de tipo compuesto porque se puede poner mas de una letra. 
            DateTime date = DateTime.Now;
            // Datetime representa una clase. Cuando de pone el .now le estamos indicando que es la fecha y la hora de ahora.
            bool siOno= false;
            // Se le asigna los valores de True o False

            int numero = new int();
            Console.WriteLine(numero.ToString());
            // numero ya tiene valor por defecto. Es una curiosidad de C#. Todos los tipos como int, float, etc se pueden inicializar como objetos y tienen sus metodos.
            // Los elementos nativos tienen valor por defecto. En el caso del int, el valor por defecto es 0. No se le puede asignar asi como esta un null
            int? numerito = null;
            float? nu = null;
            char? letrita = null;
            // De esta forma se le puede asignar null a los tipos nativos.

            // palabra reservada -> VAR. Sirve para asignar variables
            var nombree = "Candela";
            // una vez que esta definido no se le puede cambiar. Si ya es string, me va a amarcar error si quiero hacer
            // nombre = 1; 
            // var solo funciona en local, es decir dentro de los métodos.
            // hay que ser especifico con el nombre de las variables.
            var limite = 50;

            // tipo de dato que heredan todos en C# -> OBJECT. Es la base de todos los elementos en C# .NET
            object persona = new{ nombre = "Candela", apellido = "Martinez"};
            // De esta forma tiene valor anonimo
            // La palabra new especifica que es un objeto. HAY QUE PONERLO SIEMPRE
            // Console.WriteLine(persona.nombre);
            // de esta forma no me va a permitir ingresar al objeto porque es de tipo anonimo. 

            var personita = new { nombre = "Candela", apellido = "Martinez", edad = 22 };
            Console.WriteLine(personita.edad);
            // de esta forma si permite ingresar al objeto. var permite tener un tipo anonimo y acceder a los datos.
        }
    }
}