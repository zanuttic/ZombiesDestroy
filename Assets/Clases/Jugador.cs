using System.Collections.Generic;
using System.Linq;
using Assets.Clases;

public class Jugador : ObjetoBase

{
    /// <summary>
    /// Coleccion de Armas que va recuperando el jugador
    /// </summary>
    private List<Arma>  _armas = new List<Arma>();

    /// <summary>
    /// Coleccion de Armas que va recuperando el jugador
    /// Solo lectura
    /// </summary>
    public List<Arma> Armas
    {
        get { return _armas; }
        //set { _armas = value; }
    }

    /// <summary>
    /// Arma seleccionada por el jugador. 
    /// Solo lectura
    /// </summary>
    public Arma ArmaActiva { get; private set; }


    public void getArma(Arma arma)
	{
        Armas.Add(arma);
        ArmaActiva = arma;
	    //recupera un arma
	}
	public void Dispara(Arma arma)
	{
		//recibe el arma y resuleve el disparo 

        //si se queda sin municiones cambia de arma en forma automatica
        CambiarArma();
	}

	//agregar los distintos metodos a cada colisión
	private void CambiarArma()
	{
        ArmaActiva = _armas.OrderBy(a => a.Ponderacion).Single(a => a.Cargador != 0);
        
    }



	
}
