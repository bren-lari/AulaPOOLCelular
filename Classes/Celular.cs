using System;

namespace AulaPOOLCelular.Classes
{
    public class Celular
    {
        public string modeloDoCelular;

        public string cor;

        public double tamanho;

        public bool ligado;

        public bool desligarOCelular;

        public bool verMensagens;

        public bool enviarMensagens;

        public string fazerLigações;

         public void Ligar(bool ligado){
            if(ligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("O celular está desligado, não conseguirá acessar os recursos.");
            }
        }

        public void Desligar(bool desligarOCelular){
            if(ligado == true){
                Console.WriteLine("O celular está ligado");
            }else{
                Console.WriteLine("O celular está desligado, não conseguirá acessar os recursos.");
            }
        }
    }
}