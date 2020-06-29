
using System;
using System.Collections.Generic;
using System.Linq;

namespace juegoIA
{
	public class ComputerPlayer: Jugador
	{       //lista de naipes
		private List<int> naipes = new List<int>();
		    //lista arbol
		private ArbolGeneral<jugada> arbol;


		public ComputerPlayer()
		{
		}
		
		public override void  incializar(List<int> cartasPropias, List<int> cartasOponente, int limite)
		{
			//Implementar
		}
		
		
		public override int descartarUnaCarta()
		{
			//Implementar
			return 0;
		}
		
		public override void cartaDelOponente(int carta)
		{
			//implementar
			
		}
		   //clase nueva
		public class jugada
        {
			int carta;
			int limiteActual;
			int ganadas;
			bool miAI;

		   //constructor de la clase jugada
		   public jugada(int carta, int limiteActual, int ganadas, bool miAI)
            {
				this.carta = carta;
				this.limiteActual = limiteActual;
				this.ganadas = ganadas;
				this.miAI = miAI;
            }
			//get y set
			public int Carta
            {
                get { return this.carta; }
            }

			public int LimiteActual
            {
                get { return this.limiteActual; }
            }

			public int Ganadas
            {
                get { return ganadas; }
                set { this.ganadas = value; }
            }

			public bool MiAI
            {
                get { return miAI; }
            }
        }
		
	}
}
