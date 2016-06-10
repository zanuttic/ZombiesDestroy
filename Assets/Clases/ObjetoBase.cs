using UnityEngine;

namespace Assets.Clases
{
    public abstract class ObjetoBase : MonoBehaviour
    {
        /// <summary>
        /// Nombre asignado al objeto instanciado
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Nivel Actual de vida del objeto instanciado
        /// </summary>
        public int NivelVida { get; set; }

        /// <summary>
        /// Valor entero que representa el tiempo de vida o la cantidad de energia del objeto
        /// </summary>
        public int Vida { get; set; }

        /// <summary>
        /// Velocidad a la que va a desplazarce el objeto instanciado
        /// </summary>
        public float Velocidad { get; set; }

        /// <summary>
        /// valor Booleano para determinar si se desea que el objeto instanciado tenga un comportamiento 
        /// titilante antes de agotarse su vida
        /// </summary>
        public bool Agoniza { get; set; }

        /// <summary>
        /// valor entero del porcentage en que se desea mostrar la agonia del objeto
        /// </summary>
        public int TiempoAgonia { get; set; }

        private void LateUpdate()
        {
            
            if (Agoniza && this.transform.gameObject.activeSelf && NivelVida <= ((TiempoAgonia * Vida) / 100))
            {
                this.transform.gameObject.SetActive(false);
            }
            else
            {
                this.transform.gameObject.SetActive(true);
            }


        }
    }
}
