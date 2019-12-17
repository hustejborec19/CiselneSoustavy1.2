/*! \mainpage Programová dokumentace
 *
 * \section intro Úvod
 *
 * Vítejte na úvodní stránce projektu do předmětu NVS, Převodu číselných soustav.
 *
 * \section motiv Využití programu
 *
 * Tento jednoduchý program slouží k převodu desítkového čísla zadaného uživatelem do uživatelem vybrané soustavy.
 * 
 * \subsection Tým
 * 
 * Na tento projekt se ze začátku měli podílet 4 studenti, postupem času jsme ale nakonec zbyli pouze dva.
 * 
 *  - Jakub Mokruša (Převzal dodatečně velitelství týmu)
 *  - Daniel Kolečkář (Zástupce velitele týmu)
 *
 * Děkujeme za přečtení úvodní strany a přejeme krásný zážitek při užívání našeho programu!
 */

using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiselneSoustavy
{/**
 * \brief Třída charakterizující převod do číselných soustav.
 */
    public class Prevod
    
    {
        public int Vstup { get; set; } /**< Zadané číslo uživalem*/

        public Prevod(int vstup)
        /**
* \brief Konstruktor třídy Převod
* \param Vstup Zadané číslo uživatelem
*/
        {
            Vstup = vstup;
        }

       

        public List<int> DecToBinary()
        /**
 * \brief Metoda vrací desítkové číslo převedené do binární soustavy
 * \param Vstup Zadané číslo uživatelem
 * \return Číslo uživatele v binární soustavě
 */
        {
            List<int> Vysledek = new List<int>();
            for (int i = 0; Vstup > 0; i++)
            {
                Vysledek.Add(Vstup % 2);
                Vstup = Vstup / 2;
            }
            Vysledek.Reverse();
            return Vysledek;
        }



        public List<int> DecToOct()
        /**
* \brief Metoda vrací desítkové číslo převedené do oktální soustavy
* \param Vstup Zadané číslo uživatelem
* \return Číslo uživatele v oktální soustavě
*
*/
        {
            List<int> Vysledek = new List<int>();
            for (int i = 0; Vstup > 0; i++)
            {
                Vysledek.Add(Vstup % 8);
                Vstup = Vstup / 8;
            }
            Vysledek.Reverse();
            return Vysledek;
        }

        public string DecToHexa()
        /**
* \brief Metoda vrací desítkové číslo převedené do šestnáctkové soustavy
* \param Vstup Zadané číslo uživatelem
* \return Číslo uživatele v šestnáctkové soustavě
*/
        {
            string Vysledek;

            Vysledek = Convert.ToString(Vstup, 16);
            return Vysledek;

        }
        

        
    }
 
        class Program
        {          static void Main(string[] args)

            {
                Console.WriteLine("------------------- ČÍSELNÉ SOUSTAVY -------------------");
                Console.WriteLine("------------ Jakub Mokruša, Daniel Kolečkář ------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Stiskněte [1] pro převedení čísla do binární soustavy");
                Console.WriteLine("Stiskněte [2] pro převedení čísla do oktálové soustavy");
                Console.WriteLine("Stiskněte [3] pro převedení čísla do šestnáctkové soustavy");
            Console.WriteLine("Volbu potvrďte stisknutím klávesy ENTER.");
                string input = " ";
                int number;
                bool res = true;
                int menu = int.Parse(Console.ReadLine());
                Prevod Vstup = null;
                List<int> pole = new List<int>();
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("------------------- ČÍSELNÉ SOUSTAVY -------------------");
                        Console.WriteLine("------------ Jakub Mokruša, Daniel Kolečkář ------------");
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("[1] Převod z decimální do binární soustavy");
                        Console.WriteLine("Napište číslo v decimální soustavě a stiskněte ENTER");
                        do
                        {

                            input = Console.ReadLine();
                            res = int.TryParse(input, out number);
                            if (res != true)
                            {
                                Console.WriteLine("Zadal jsi špatný vstup, prosím zadej číslo..");
                            }
                        } while (res != true);
                        Vstup = new Prevod(number);
                        pole = Vstup.DecToBinary();
                        Console.Write("Po převedení do binární soustavy: ");
                        for (int i = 0; i < pole.Count; ++i)
                            Console.Write(pole[i]);

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("------------------- ČÍSELNÉ SOUSTAVY -------------------");
                        Console.WriteLine("------------ Jakub Mokruša, Daniel Kolečkář ------------");
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("[2] Převod z decimální do oktálové soustavy");
                        Console.WriteLine("Napište číslo v decimální soustavě a stiskněte ENTER");
                        do
                        {
                            input = Console.ReadLine();
                            res = int.TryParse(input, out number);
                            if (res != true)
                            {
                                Console.WriteLine("Zadal jsi špatný vstup, prosím zadej číslo..");
                            }
                        } while (res != true);
                        Vstup = new Prevod(number);
                        Console.Write("Po převedení do oktálové soustavy: ");
                        pole = Vstup.DecToOct();
                        for (int i = 0; i < pole.Count; ++i)
                        Console.Write(pole[i]);

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("------------------- ČÍSELNÉ SOUSTAVY -------------------");
                        Console.WriteLine("------------ Jakub Mokruša, Daniel Kolečkář ------------");
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("[3] Převod z decimální do šestnáctkové soustavy");
                        Console.WriteLine("Napište číslo v decimální soustavě a stiskněte ENTER");
                        do
                        {
                            input = Console.ReadLine();
                            res = int.TryParse(input, out number);
                            if (res != true)
                            {
                                Console.WriteLine("Zadal jsi špatný vstup, prosím zadej číslo..");
                            }
                        } while (res != true);
                        Vstup = new Prevod(number);
                        Console.WriteLine("Po převedení do šestnáctkové soustavy: "+Vstup.DecToHexa());
                        break;

                default:
                        Console.Clear();
                        Console.WriteLine("Jejda! Zadal jsi špatnou hodnotu! Zkus to znovu..");
                    
                    break;
                }



                Console.ReadKey();
            }
        }
    }
