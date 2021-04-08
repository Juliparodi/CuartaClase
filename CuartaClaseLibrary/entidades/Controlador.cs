using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuartaClaseLibrary.entidades
{
    public class Controlador
    {
        int _codigo;
        int _orden;
        List<Boton> _botones;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Orden { get => _orden; set => _orden = value; }

        public Controlador(int codigo, int orden)
        {
            _codigo = codigo;
            _orden = orden;
            _botones = new List<Boton>();
        }

        public Controlador() { }

        public void AgregarBoton(Boton btn)
        {
            if(_botones.Any(item => item.Codigo.Equals(btn.Codigo)))
            {
                throw new BotonYaExistenteException("El boton con codigo: {0} ya existe en la lista", btn.Codigo);
                    
            } else {
                _botones.Add(btn);
            }
            
        }

        public void AgregarBoton(int cod, string descripcion)
        {
            if (_botones.Any(item => item.Codigo.Equals(btn.Codigo)))
            {
                throw new BotonYaExistenteException("El boton con codigo: {0} ya existe en la lista", btn.Codigo);

            }
            else
            {
                Boton btn = new Boton(cod, descripcion);
                _botones.Add(btn);
            }
        }

        public void EliminarBoton(int cod)
        {
            Boton btn = _botones.SingleOrDefault(x => x.Codigo.Equals(cod));
            if (btn.Equals(null))
            {
                throw new BotonNoExistenteException("El boton con cod: {0} no existe", cod);
            }
            _botones.Remove(btn);
        }
            

        public string TraerDescripcion(int cod)
        {
                Boton btn = _botones.SingleOrDefault(x => x.Codigo.Equals(cod));
                if (btn.Equals(null))
                {
                    throw new BotonNoExistenteException("El boton con cod: {0} no existe", cod);
                } 

                return btn.Description;
        }

        public bool EsPrimero()
        {
            if (this._orden == 0)
            {
                throw new OrdenCeroException();
            }

            if (this._orden < 0)
            {
                throw new Exception("orden no puede ser negativo");
            }

            return this._orden == 1;
        }

    }
}
