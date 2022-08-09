using System;

namespace LiçãoIBM_09_08_22 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Escolha o DDD: (11) (19) (21) (27) (31) (32) (61) (71)");

            for (int i = 0; i < 9; i++) {
                int DDD = int.Parse(Console.ReadLine());

                if (DDD == 11) {
                    Console.WriteLine("São Paulo");
                }
                else if (DDD == 19) {
                    Console.WriteLine("Campinas");
                }
                else if (DDD == 21) {
                    Console.WriteLine("Rio de Janeiro");
                }
                else if (DDD == 27) {
                    Console.WriteLine("Vitoria");
                }
                else if (DDD == 31) {
                    Console.WriteLine("Belo Horizonte");
                }
                else if (DDD == 32) {
                    Console.WriteLine("Juiz de Fora");
                }
                else if (DDD == 61) {
                    Console.WriteLine("Brasilia");
                }
                else if (DDD == 71) {
                    Console.WriteLine("Salvador");
                }
                else {
                    Console.WriteLine("DDD Incorreto");
                }
            }
        }
    }
}