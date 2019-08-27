/*
 * Berechnen Sie nochmals den bereits eingeführten Bodymassenindex bmi,
 * allerdings mit Benutzereingabe von Gewicht und Größe (beides 'double')
 *
 *     Bodymassenindex: bmi = gewicht[kg]/groesse[m]^2
 *
 * Werten Sie den errechneten bmi anhand der folgenden Kriterien aus:
 *
 *     - bmi < 10       => Überprüfen Sie ihre Eingabe
 *     - 10 <= bmi < 15 => Magersucht
 *     - 15 <= bmi < 20 => Untergewicht
 *     - 20 <= bmi < 25 => Normalgewicht
 *     - 25 <= bmi < 30 => Übergewicht
 *     - 30 <= bmi < 40 => Fettsucht
 *     - 40 <= bmi < 50 => morbide Fettsucht
 *     - bmi >= 50      => Überprüfen Sie ihre Eingabe
 *
 * Geben Sie bei erfüllter Bedingung jeweils den entsprechenden Text aus
 */


/*
* Aufgabe 1: Implementieren Sie eine geeignete Benutzerschnittstelle
*            zur Eingabe der benötigten Werte. Fangen Sie eventuelle
*            fehlerhafte Benutzereingaben mittels 'try-catch'-Blöcken
*            ab. Falls der Benutzer irrtümlicherweise bei der Eingabe von
*            Gleitkommawerten zur Trennung von Ganzzahl- und Nachkommaanteil
*            die Punktnotation verwendet, ersetzen Sie den Punkt durch ein
*            Komma.
*/



/*
 * Aufgabe 2: Werten Sie den Bodymassen-Index einfach mittels if-Anweisungen
 *            und logischen Vergleichs- und Verknüpfungs-Operatoren aus
 */



/*
 * Aufgabe 3: Führen Sie eine möglichst effiziente Auswertung durch,
 *            d.h. vermeiden Sie möglichst viele Bedingungsauswertungen
 */


using System;

namespace Uebung05BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {

            String eingabe = "";
            double gewicht = 0.0;
            double groesse = 0.0;

            bool eingabeOK = false;

            Console.Write("Geben Sie ihr Gewicht in kg an: ");



            eingabe = Console.ReadLine();


            eingabeOK = double.TryParse(eingabe, out gewicht);




            Console.Write("Geben Sie ihre Groesse in m an: ");

            double bmi = berechneBmi(80, 1.83);
            Console.WriteLine(bmi);





            Console.ReadKey();

        }





        static double berechneBmi(double gewicht, double groesse)
        {
            // Bodymassenindex: bmi = gewicht[kg] / groesse[m] ^ 2
            double bmi = gewicht / Math.Pow(groesse, 2);

            return bmi;
        }
    }
}
