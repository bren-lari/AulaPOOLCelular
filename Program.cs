using System;
using AulaPOOLCelular.Classes;

namespace AulaPOOLCelular
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Celular Celular1 = new Celular();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira o modelo do celular: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Celular1.modeloDoCelular = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira a cor do celular: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Celular1.cor = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira o tamanho do celular -> OBS: Somente números e vírgulas: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Celular1.tamanho = double.Parse(Console.ReadLine());

              string  resposta;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("O celular esta ligado? (Sim ou Não): ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            resposta = Console.ReadLine();

            if(resposta  == "Sim") {
                Celular1.ligado = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--- Ligando celular... ---");
            }else if(resposta == "Não"){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, ligue o ceular para acessar os recursos.");
                Celular1.desligarOCelular = false;
            }


           if(resposta == "Sim"){
            do{
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\r\nConfigurações");
                Console.WriteLine("_________________________");
                Console.WriteLine("\r\nSelecione o recurso que deseja executar: ");
                Console.WriteLine("[1º-> Ligar o celular]");
                Console.WriteLine("[2º-> Desligar o celular]");
                Console.WriteLine("[3º -> Ver mensagens]");
                Console.WriteLine("[4º -> Enviar mensagens]");
                Console.WriteLine("[5º -> Fazer ligações]");
                Console.WriteLine("[0] Sair das configurações");
                resposta = Console.ReadLine();

                switch (resposta)
              {
                  case "1":
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                  Console.WriteLine("--- Pressione o botão ligar e desligar do celular, \r\nsegure por mais ou menos 5 segundos e espere ele ligar ---");
                break;

                 case "2":
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("--- Pressione o botão ligar e desligar do celular, \r\nsegure por mais ou menos 5 segundos e espere ele desligar. ---");

                break;

                case "3":
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("--- Lendo mensagem... ---");

                break;

                case "4":
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("--- Enviando mensagem... ---");

                break;

                 case "5":
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("--- Chamando... ---");

                break;

                
              }

                
            } while (resposta !="0");

           }




        }
    }
}
           
