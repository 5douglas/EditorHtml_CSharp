using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
            
            var option = short.Parse(Console.ReadLine()); 
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.Clear();
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");

            }
            Console.Write("+");
            for(int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(1,0);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(1,1);
            Console.WriteLine("===================");
            Console.SetCursorPosition(1,2);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(1, 4);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(1, 5);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(1, 7);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine("Opção:");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}