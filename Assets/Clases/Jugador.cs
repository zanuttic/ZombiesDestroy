using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour
{
	public Arma  armas;//generar una coleccion
	public int vida { get; set;}
	public float velocidad{ get; set;}
	private Arma armaActiva{ get; set; }



	private void getArma()
	{
		//recupera un arma
	}
	private void Dispara(Arma arma)
	{
		//recibe el arma y resuleve el disparo 

	}

	//agregar los distintos metodos a cada colisión
	private void CambiarArma(Arma armas)
	{
		
	}



	
}
