using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoIA
{
    public class Jugada
    {
        public int carta;
        public int limiteActual;
        public int ganadas;
        public bool miAI;

        public Jugada(int carta, int limiteActual, int ganadas, bool miAI)
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
