
using System;

namespace juegoIA
{
    class Juego
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
      
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Juego de naipes\n");
            Console.WriteLine("Elija una opcion del menu:");
            Console.WriteLine("1) Comenzar partida");
            Console.WriteLine("2) Posibles jugadas");
            Console.WriteLine("3) Salir");
            Console.Write("\r\nElija una opcion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Game game = new Game();
                    game.play();
                    Console.ReadKey();
                    return true;
                case "2":
                    Console.WriteLine("No implementado");
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
    }   
}
