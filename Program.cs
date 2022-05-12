using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EserciziPrimoGiorno
{
    public class EsercizioZero
    {
        public void StampaMax()
        {
            string sAppo;
            int iPrimoNumero, iSecondoNumero;
            Console.WriteLine("Inserisci primo numero:");
            sAppo = Console.ReadLine();
            iPrimoNumero = Convert.ToInt32(sAppo);

            Console.WriteLine("Inserisci secondo numero:");
            sAppo = Console.ReadLine();
            iSecondoNumero = Convert.ToInt32(sAppo);

            if (iPrimoNumero > iSecondoNumero)
                Console.WriteLine("Il numero più grande è {0}", iPrimoNumero);
            else
                Console.WriteLine("Il numero più grande è {0}", iSecondoNumero);
        }
    }



    public class EsercizioA
    {
        public void StampaMassimo()
        {
            int[] viMioVettore = { 3, 8, 5, 32, 23, 4 };
            int iMax = viMioVettore.Max();
            Console.WriteLine("Il massimo è: {0}", iMax);
        }
    }



    public class Eserciziob
    {
        //Facciamo un ciclo for con 10 if dentro da 0 a 9

        public void VerificaStringaNumerica1()
        {
            string sMiaStringa = "123a";
            char cMyChar;

            



            for (int i=0;i<sMiaStringa.Length;i++)
            {
                cMyChar = sMiaStringa[i];
                if ((cMyChar < '0') || (cMyChar > '9'))
                    Console.WriteLine("kokoko");
            }
        }

        public bool VerificaStringaNumerica2(string s)
        {
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s, i))
                    break;
            }
            if (i < s.Length)
                return false;
            else
                return true;
        }

        //Usare il metodo Int32.TryParse

        /*
        byte bMioByte;
        bMioByte = (byte)sMiaStringa[1];
        */
    }



    public class PrimoEsercizio
    {
        //Dichiarare un array dei mesi e stampare tutti i mesi dell’anno in
        //console in una lista ordinata.
        private string[] vsMesi = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio" };

        public void StampaMesiAnno()
        {
            Console.WriteLine("I mesi dell'anno sono {0}:", vsMesi.Length);
            for(int i=0;i< vsMesi.Length; i++)
            {
                Console.WriteLine($"{vsMesi[i]}");
            }
        }
    }


    public class SecondoEsercizio
    {
        //Dichiarare un vettore hard-coded di numeri.Ciclare su quel vettore e se il numero è pari
        //stampare a video: “Il numero è pari” 
        //se invece il numero scelto è dispari: “Il numero è dispari”
        int[] myArray = new int[10];

        //La lunghezza del vettore è 10 e i singoli elementi sono inizializzati a zero. 
        public void RiempiVettore()
        {
            Random random = new Random();
            for (int i=0;i<myArray.Length;i++)
            {
                myArray[i] = random.Next(100);
            }
        }

        //Da notare che un vettore lungo 10 ha indici da zero a nove.
        public void StampaVettore()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"L'elemento {i} del vettore contiene {myArray[i]}");
            }
        }

        //Da notare che un vettore lungo 10 ha indici da zero a nove.
        public void StampaVettorePariDispari()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i]%2 == 0)
                    Console.WriteLine($"L'elemento {i} del vettore contiene {myArray[i]} PARI");
                else
                    Console.WriteLine($"L'elemento {i} del vettore contiene {myArray[i]} DISPARI");
            }
        }



    }


    public class TerzoEsercizio
    {
        //Chiedere all’utente di inserire 2 parole e informare l’utente quale è la parola più lunga.
        //Ripetere il gioco all’infinito.Poi chiedere all’utente se vuole ripetere il gioco e di conseguenza
        //fermarsi quando l’utente lo desidera.Rifar rivedere l’importanza del ciclo while.
        string[] vsParole = new string[2];

        public void InserisciDati()
        {
            Console.WriteLine("Inserisci prima parola:");
            vsParole[0] = Console.ReadLine();
            Console.WriteLine("Inserisci seconda parola:");
            vsParole[1] = Console.ReadLine();
        }

        public void StampaParolaPiuLunga()
        {
            if (vsParole[0].Length == vsParole[1].Length)
                Console.WriteLine("Le due parole hanno la stessa lunghezza");
            else
            {
                if (vsParole[0].Length > vsParole[1].Length)
                    Console.WriteLine($"La parola piu lunga è { vsParole[0]}");
                else
                    Console.WriteLine($"La parola piu lunga è { vsParole[1]}");
            }
        }
    }

    
    public class ProcessaDirectory
    {
        //L'utente inserisce il path (assoluto o relativo di una directory)
        //ed il programma restituisce quanti file contiene la directory 
        public void ContaFilesInDirectory()
        {
            Console.WriteLine("Inserisci il path di una directory:");
            string sPath = Console.ReadLine();
            if (System.IO.Directory.Exists(sPath))
            {
                string sFileName = "";
                string[] fileEntries = System.IO.Directory.GetFiles(sPath);
                int iNumFilesInDir = fileEntries.Length;
                for(int i=0;i< iNumFilesInDir;i++)
                {
                    sFileName = fileEntries[i];
                    Console.WriteLine($"File: {sFileName}");
                }       
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", sPath);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int i = '1';
            Console.WriteLine(i);




            //ESERCIZIO ZERO
            //Chiedere all'utente di inserire due numeri e stampare 
            //il più grande


            //ESERCIZIO A
            //Chiedere all'utente di inserire 50 numeri e stampare il più grande
            //Suggerimento ciclo for e tengo sempre il massimo

            //Secondo metodo: tengo i 50 numeri in un vettore di interi e poi prendo il
            //massimo
            //EsercizioA vEsercizio = new EsercizioA();
            //vEsercizio.StampaMassimo();


            //ESERCIZIO B : TEOREMA DI PITAGORA
            /*
             * L'utente inserisce due numeri (i cateti) ed è calcolata l'ipotenusa (Pitagora)
            */

            //ESERCIZIO C: COPIA DI ARRAY
            //Gli array sono tipi riferimento (non sono tipi valore)
            //per cui vengono allocati nell’heap (no nello stack).
            //Dimostrare questo con un esempio

            /*
             * Gli interi sono tipi di valore: dimostrare ciò
            */



            /*
            int[] a1 = { 1, 2, 3, 4 };
            int[] a2 = a1;

            I due array ‘a1’ e ‘a2’ fanno riferimento alla stessa area di memoria, 
            per cui se si modifica un elemento di a1, si modifica anche l’elemento 
            corrispondente di a2, e viceversa.
            */



            //ESERCIZIO D: VERIFICARE CHE UNA STRINGA SIA NUMERICA
            //Eserciziob vEsercizioB = new Eserciziob();
            //vEsercizioB.VerificaStringaNumerica1();




            //CALCOLARE LA PASQUA
            /*
             * int year = Convert.ToInt32(txtYear.Text);
       int a = year % 19;
       int b = year / 100;
       int c = year % 100;
       int d = b / 4;
       int e = b % 4;
       int f = (b + 8) / 25;
       int g = (b - f + 1) / 3;
       int h = (19 * a + b - d - g + 15) % 30;
       int i = c / 4;
       int j = c % 4;
       int k = (32 + 2 * e + 2 * i - h - j) % 7;
       int l = (a + 11 * h + 22 * k) / 451;
       int month = (h + k - 7 * l + 114) / 31;
       int day = ((h + k - 7 * l + 114) % 31) + 1;
       DateTime easter = new DateTime(year, month, day);   // This is the easter.
            */







            //PRIMO ESERCIZIO
            //Dichiarare un array dei mesi e stampare tutti i mesi dell’anno in
            //console in una lista ordinata.
            PrimoEsercizio vPrimoEsercizio = new PrimoEsercizio();
            vPrimoEsercizio.StampaMesiAnno();
            //PremiEnterPerUscire();



            //SECONDO ESERCIZIO
            //Dichiarare un vettore hard-coded di numeri.Ciclare su quel vettore e se il numero è pari
            //stampare a video: “Il numero è pari” 
            //se invece il numero scelto è dispari: “Il numero è dispari”

            //SecondoEsercizio vSecondoEsercizio = new SecondoEsercizio();
            //vSecondoEsercizio.RiempiVettore();
            //vSecondoEsercizio.StampaVettore();
            //vSecondoEsercizio.StampaVettorePariDispari();
            //PremiEnterPerUscire();



            //TERZO ESERCIZIO
            //Chiedere all’utente di inserire 2 parole e informare l’utente quale è la parola più lunga.
            //Ripetere il gioco all’infinito.Poi chiedere all’utente se vuole ripetere il gioco e di conseguenza
            //fermarsi quando l’utente lo desidera.Rifar rivedere l’importanza del ciclo while.

            //TerzoEsercizio vTerzoEsercizio = new TerzoEsercizio();
            //vTerzoEsercizio.InserisciDati();
            //vTerzoEsercizio.StampaParolaPiuLunga();
            //PremiEnterPerUscire();

            TerzoEsercizio vTerzoEsercizio = new TerzoEsercizio();
            int iFlag = 1;
            while (iFlag == 1)
            {
                vTerzoEsercizio.InserisciDati();
                vTerzoEsercizio.StampaParolaPiuLunga();
                Console.WriteLine("Vuoi continuare?");
                if (Console.ReadLine().ToLower() != "si")
                    iFlag = 0;
            }


            //Quarto esercizio
            //Usa una funzione che conta i file di una cartella


            //Quinto esercizio
            /*
            Conta i file di una cartella
            Crea un ciclo infinito while
            Fai una sleep di tre secondi
            Se il numero di file nella cartella è cambiato scrivi un alert a schermo.

            Per la sleep aggiungere le seguenti due righe
            using system.Threading;

            Thread.sleep(2000);

            */





            //Settimo esercizio
            /*
            Spiego la distanza di levenshtein tra due stringhe ed esempi in cui serve.
            Spiego il correttore ortografico inventato da me e il fatto che lo implementeremo

            L'implementazione della distanza di LEvenShtein è difficile
            Una forma semplificata la definizmo tra due stringhe di uguale lunghezza: la distanza tra 
            cane e pane è la distanza tra asci(c) e asci(p).
             * */


            //PremiEnterPerUscire();


        }

        static private void PremiEnterPerUscire()
        {
            Console.WriteLine("Premi <enter> per uscire");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nAttento: per uscire devi premere enter");
            }
        }





    }
}
