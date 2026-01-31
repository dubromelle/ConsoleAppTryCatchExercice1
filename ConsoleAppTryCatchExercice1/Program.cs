using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatchExercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 17, 0, -15, 38, 29, 157, 89, -22, 12, 5 };
            int x, y;
            bool ok = true;

            try
            {
                Console.WriteLine("Entrez l’indice de l’entier à diviser : ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrez le diviseur: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Le résultat de la division est : {0}", Division(tableau, x, y));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static int Division(int[] monTableau, int indice, int diviseur)
        {
            try
            {
                return (monTableau[indice] / diviseur);
            }
            catch (ArithmeticException ex)
            {
                throw new ArithmeticException("Erreur arithmétique (division par zéro)", ex);

            }
            catch (IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException("L’indice n'existe pas dans le tableau", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur dans la méthode Division()", ex);
            }
        }
    }
}
