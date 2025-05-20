using BibliothequeFonctionsDeBase;
namespace Examen_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FonctionsDeBase.AfficherLigne("Convertion ");
            int pouces;
            pouces = FonctionsDeBase.LireEntierPositif("Entre la pouce : ");
            
            double centimetre = ConvertionEnCm(pouces);
            double metre  = ConvertionEnMetre(pouces);
            ConvertionEnPied(pouces);
            Console.WriteLine($"Affichage en cm : {centimetre:F2} cm");
            Console.WriteLine($"Affichage en metre : {metre:F3} m");
        }
        /// <summary>
        /// La convertion de pouce en pied
        /// </summary>
        /// <param name="pouces"></param>
        static void ConvertionEnPied(int pouces)
        {
            int pied;
            pied = (pouces / 12);
            int pouce = (pouces % 12);
            Console.WriteLine("Affichage en pied, pouce   :  " + pied +" pieds, " + pouce +" pouces");
        }

        /// <summary>
        /// Convertion de pouces en centimetre
        /// </summary>
        /// <param name="pouces"></param>
        /// <returns>retourne la convertion en Cm</returns>
        static double ConvertionEnCm(int pouces)
        {
            double centimetre;
            centimetre = pouces * 2.54;
            return centimetre;
        }

        /// <summary>
        /// Convertion de pouce en metre 
        /// </summary>
        /// <param name="pouces"></param>
        /// <returns>retourne la convertion en metre </returns>
        static double ConvertionEnMetre(int pouces)
        {
            double centimetre = ConvertionEnCm(pouces);
            double metre;
            metre = (centimetre / 100);
            return metre;

        }
       
    }
}
