using System;

namespace TP2
{
	public class ArbolBinario<T>
	{
		
		private NodoBinario<T> raiz;

		public ArbolBinario(T dato) {
			this.raiz = new NodoBinario<T>(dato);
		}
	
		private ArbolBinario(NodoBinario<T> nodo) {
			this.raiz = nodo;
		}
	
		private NodoBinario<T> getRaiz() {
			return raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return new ArbolBinario<T>(this.raiz.getHijoIzquierdo());
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return new ArbolBinario<T>(this.raiz.getHijoDerecho());
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.raiz.setHijoIzquierdo(hijo.getRaiz());
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.raiz.setHijoDerecho(hijo.getRaiz());
		}
	
		public void eliminarHijoIzquierdo() {
			this.raiz.setHijoIzquierdo(null);
		}
	
		public void eliminarHijoDerecho() {
			this.raiz.setHijoDerecho(null);
		}
	
		public bool esVacio() {
			return this.raiz == null;
		}
	
		public bool esHoja() {
			return this.raiz != null && this.getHijoIzquierdo().esVacio() && this.getHijoDerecho().esVacio();
		}
		
		public void inorden()
		{
			if (!this.esVacio())
			{
				//llamada recursiva hijo izquierdo
				if (!this.getHijoIzquierdo().esVacio());
				this.getHijoIzquierdo().inorden();

				//llamada recursiva hijo derecho
				if (!this.getHijoDerecho().esVacio());
				this.getHijoDerecho().inorden();
			}
		}
		
		public void preorden()
		{
			if (!this.esVacio())
			{
				//proceso primero la raiz
				Console.Write(this.getDatoRaiz() + " ");

				//llamada recursiva hijo izquierdo
				if (!this.getHijoIzquierdo().esVacio());
				this.getHijoIzquierdo().preorden();

				//llamada recursiva hijo derecho
				if (!this.getHijoDerecho().esVacio()) ;
				this.getHijoDerecho().preorden();
			}
		}
		
		public void postorden() 
		{
			//llamada recursiva hijo izquierdo
			if (!this.getHijoIzquierdo().esVacio());
			this.getHijoIzquierdo().postorden();

			//llamada recursiva hijo derecho
			if (!this.getHijoDerecho().esVacio());
			this.getHijoDerecho().postorden();

			Console.Write(this.getDatoRaiz() + " ");
		}
		
		public void recorridoPorNiveles() 
		{
		 Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> arbolAux;

			//encolamos Arbol
			c.encolar(this);
			while (c.esVacio())
			{
				//desencolamos arbol
				arbolAux = c.desencolar();

				//imprimimos datos de la raiz del arbol
				Console.Write(arbolAux.getDatoRaiz() + " ");

				//si tiene hijo izquierdo
				if (arbolAux.getHijoIzquierdo().esVacio());

				//lo encolamos
				c.encolar(arbolAux.getHijoIzquierdo());

				//si tiene hijo derecho
				if (!arbolAux.getHijoDerecho().esVacio());

				//lo encolamos
				c.encolar(arbolAux.getHijoDerecho());
				
			}
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m)
		{
			if (!this.esVacio())
			{
				Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();

				//variable auxiliar
				ArbolBinario<T> arbolAux;

				//contador
				int contNivel = 0;

				//encolamos arbol
				c.encolar(this);

				//encolamos separador de niveles
				c.encolar(null);

				while (!c.esVacia())
				{
					//desencolamos arbol
					arbolAux = c.desencolar();
					if (arbolAux == null)
					{
						if (contNivel >= n && contNivel <= m)
						{
							Console.Write(arbolAux.getDatoRaiz() + " ");
						}
					}
					//si tiene hhijo izquierdo
					if (!arbolAux.getHijoIzquierdo().esVacio())
					{
						//lo encolamos
						c.encolar(arbolAux.getHijoIzquierdo());

						//si tiene hijo derecho
						if (!arbolAux.getHijoDerecho().esVacio()) ;
						//lo encolamos
						c.encolar(arbolAux.getHijoDerecho());
					}
					else
					{
						contNivel++;
						if (!c.esVacio()) ;
						c.encolar(null);
					}

				}
			

			}
			

		}
	}
}
