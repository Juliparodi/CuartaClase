using CuartaClaseLibrary.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = 0;
            string descripcion = "hola";

            Boton btn = new Boton(cod, descripcion);
            Controlador controlador = new CuartaClaseLibrary.entidades.Controlador();

            try {
                controlador.AgregarBoton(btn);
            } catch (BotonYaExistenteException ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                controlador.EliminarBoton(btn);
            } catch (BotonNoExistenteException ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                string desc1 = controlador.TraerDescripcion(cod);
                Console.WriteLine("la descripcion del boton es: {0}", desc1);
            }
            catch (BotonNoExistenteException ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();


        }
    }
}
