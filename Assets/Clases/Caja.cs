using UnityEngine;

namespace Assets.Clases
{
    public class Caja : ObjetoBase
    {
        public Transform objetos{ get; set; } //generar una coleccion de los objetos que va a contener

        //metodo star instanciar los objetos que va a transportar y desactivarlos
        
        /// <summary>
        /// Evalua el lugar de caida para no caer sobre otro objeto
        /// si en el camino un objeto se posiciona de bajo de esta
        /// cambia su rumbo
        /// </summary>
        private void PosicionCaida()
        {
		
        }
        /// <summary>
        /// Al destruirse la caja deja expuesto los objetos 
        /// que carga en el interior
        /// </summary>
        public void Destruccion()
        {
            //activar los objetos que carga en el interior
		
        }
    }
}