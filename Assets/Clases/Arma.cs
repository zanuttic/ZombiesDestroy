﻿using System.Collections.Generic;
namespace Assets.Clases
{
    public class Arma : ObjetoBase
    {
        /// <summary>
        /// cantidad total de municiones instanciadas junto al arma
        /// </summary>
        /// <value><c>true</c> if this instance cant municion; otherwise, <c>false</c>.</value>
        public int CantMunicion{ get; set;}
        /// <summary>
        /// Cantidad de municiones en el cargador
        /// </summary>
        /// <value>The cargador.</value>
        public int Cargador{ get; set;}

        /// <summary>
        /// Valor de daño a causar en el impacto
        /// </summary>
        /// <value>The valor daño.</value>
        public float ValorDaño { get; set;}
        /// <summary>
        /// valor de retroceso al momento del disparo
        /// </summary>
        /// <value>The retroceso.</value>
        public float Retroceso{ get; set;}
        
        /// <summary>
        /// Valor entero que representa la importancia del arma, dado su poder de fuego y destruccion
        /// </summary>
        public int Ponderacion { get; set;}
        private Municion municion { get; set; }



        public float Disparar(Arma arma)
        {
            //generar el disparo, retornando el valor del retroceso
            return new float();
        }
        public void Recargar(Municion municion)
        {
            //generar la recarga del arma segun capacidad del cargador
            //siempre que el valor de CantMunicion sea distinto de cero
        }
    }
}

