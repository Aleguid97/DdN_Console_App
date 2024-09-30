using System;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Titolo con colore
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║          ╔══════════════════════╗          ║");
            Console.WriteLine("║          ║  Dungeons & Dragons  ║          ║");
            Console.WriteLine("║          ╚══════════════════════╝          ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║        ╔════════════════════════════╗      ║");
            Console.WriteLine("║        ║  Crea il tuo Personaggio!  ║      ║");
            Console.WriteLine("║        ╚════════════════════════════╝      ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("\n");

            // Testo bianco
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Benvenuto Avventuriero, sei pronto per un'avventura?");
            Console.WriteLine("Crea il tuo personaggio! \n");

            Console.WriteLine("══════════════════════════════════════════════════════\n");

            // Nome
            Console.WriteLine("Inserisci il nome del tuo personaggio:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string nome = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");




            // Razza
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Scegli la razza di {nome} (Umano, Nano, Elfo, Mezzelfo, Mezzorco, Halfling, Gnomo, Tiefling, Dragonide):");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string razzaInput = Console.ReadLine();
            Razza razza;
            while (!Enum.TryParse(razzaInput, true, out razza) || !Enum.IsDefined(typeof(Razza), razza))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Razza non valida. Riprova:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                razzaInput = Console.ReadLine();
            }
            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");

            // Sotto-Razza
            SottoRazza sottoRazza = SottoRazza.Nessuna;
            if (razza == Razza.Nano)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sotto razza di {nome} (NanoDiMontagna, NanoDiCollina, Duergar):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoRazzaInput = Console.ReadLine();
                while (!Enum.TryParse(sottoRazzaInput, true, out sottoRazza) || !Enum.IsDefined(typeof(SottoRazza), sottoRazza))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoRazzaInput = Console.ReadLine();
                }
            }
            else if (razza == Razza.Elfo)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sotto razza di {nome} (ElfoAlto, ElfoSilvano, Drow):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoRazzaInput = Console.ReadLine();
                while (!Enum.TryParse(sottoRazzaInput, true, out sottoRazza) || !Enum.IsDefined(typeof(SottoRazza), sottoRazza))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto-razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoRazzaInput = Console.ReadLine();
                }
            }

            else if (razza == Razza.Halfling)
            {
                    Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sotto razza di {nome} (PiedeLesto, Vigoroso)");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoRazzaInput = Console.ReadLine();
                while (!Enum.TryParse(sottoRazzaInput, true, out sottoRazza) || !Enum.IsDefined(typeof(SottoRazza), sottoRazza))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto-razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoRazzaInput = Console.ReadLine();
                }

            }

            else if (razza == Razza.Dragonide)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la discendeza draconica di {nome} (Argento, Bronzo, Ottone, Rame, Oro, Bianco, Blu, Nero, Rosso, Verde)");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoRazzaInput = Console.ReadLine();
                while (!Enum.TryParse(sottoRazzaInput, true, out sottoRazza) || !Enum.IsDefined(typeof(SottoRazza), sottoRazza))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto-razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoRazzaInput = Console.ReadLine();
                }

            }

            else if (razza == Razza.Gnomo)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sotto razza di{nome} (GnomodellForeste, GnomodelleRocce)");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoRazzaInput = Console.ReadLine();
                while (!Enum.TryParse(sottoRazzaInput, true, out sottoRazza) || !Enum.IsDefined(typeof(SottoRazza), sottoRazza))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto-razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoRazzaInput = Console.ReadLine();
                }

            }

            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");

            // Classe
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Scegli la classe di {nome} (Barbaro, Bardo, Chierico, Druido, Guerriero, Ladro, Mago, Monaco, Paladino, Ranger, Stregone, Warlock):");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string classeInput = Console.ReadLine();
            Classe classe;
            while (!Enum.TryParse(classeInput, true, out classe) || !Enum.IsDefined(typeof(Classe), classe))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Classe non valida. Riprova:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                classeInput = Console.ReadLine();
            }
            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");


            // Livello, Punti Vita, e Statistiche
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inserisci il livello di {nome}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int livello = LeggiInputInteroValido();

            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");



            // Sotto-Classe
            Sottoclasse sottoClasse = Sottoclasse.Nessuna;


            if (classe == Classe.Barbaro && livello >= 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (GuerrieroTotemico, Berserker):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }
            else if (classe == Classe.Bardo && livello >=3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (CollegioDellaConoscenza, CollegioDelValore):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Chierico)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (DominioDellaConoscenza, DominioDellaVita, DominioDellaLuce, DominioDellaNatura, DominioDellaTempesta, DominioDellInganno, DominioDellaGuerra):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }

            }

            else if (classe == Classe.Druido)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (CircoloDellaTerra, CircoloDellaLuna,):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }

            }

            else if (classe == Classe.Guerriero && livello >= 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (Campione, CavaliereMistico, MaestroDiBattaglia):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Ladro && livello >= 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (Furfante, Assassino):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Mago && livello >= 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (ScuolaDiAbiurazione, ScuolaDiAmmaliamento, ScuolaDiDivinazione, ScuolaDiEvocazione, ScuolaDiIllusione, ScuolaDiInvocazione, ScuolaDiNecromanzia, ScuolaDiTrasmutazione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Monaco && livello >= 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (ViaDellaManoAperta, ViaDellOmbra, ViaDeiQuattroElementi):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Paladino && livello >= 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (GiuramentoDellaDevozione, GiuramentoDegliAntichi, GiuramentoDellaVendetta):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Ranger && livello >= 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (Cacciatore, MaestroDelleBestie):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Stregone)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (StregoneDelleOmbre, StregoneDellaFiamma, StregoneDellaTempesta, StregoneDellaFuria, StregoneDellaFede):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            else if (classe == Classe.Warlock)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la sottoclasse di {nome} (PattoDellaCatena, PattoDellaLama, PattoDelTomo):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string sottoClasseInput = Console.ReadLine();
                while (!Enum.TryParse(sottoClasseInput, true, out sottoClasse) || !Enum.IsDefined(typeof(Sottoclasse), sottoClasse))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sotto razza non valida. Riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    sottoClasseInput = Console.ReadLine();
                }
            }

            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");

            // Background
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Scegli il background di {nome} (Accolito, ArtigianoDiGilda, Ciarlatano, Criminale, Eremita, EroePopolare");
            Console.WriteLine();  // Interlinea Vuota sennò si appicica al testo sopra
            Console.WriteLine("Forestiero, Intrattenitore, Marinaio, Monello, Nobile, Sapiente, Soldato)");

            Console.ForegroundColor = ConsoleColor.Cyan;
            string backgroundInput = Console.ReadLine();
            Background background;
            while (!Enum.TryParse(backgroundInput, true, out background) || !Enum.IsDefined(typeof(Background), background))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Background non valido. Riprova:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                backgroundInput = Console.ReadLine();
            }
            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scegli l'allineamento: Buono, Neutrale, Malvagio, LegaleBuono, NeutraleBuono, CaoticoBuono, LegaleNeutrale, NeutralePuro, CaoticoNeutrale, LegaleMalvagio, NeutraleMalvagio, CaoticoMalvagio ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string allineamentoInput = Console.ReadLine();
            Allineamento allineamento1;

            while (!Enum.TryParse(allineamentoInput, true, out allineamento1) || !Enum.IsDefined(typeof(Allineamento), allineamento1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Allineamento non valido. Riprova:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                allineamentoInput = Console.ReadLine();
            }
            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");

            int puntiVita = 0;

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Inserisci la Forza  di {nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int forza = LeggiInputInteroValido();
            Console.ForegroundColor = ConsoleColor.Green;
            int modificatoreForza = CalcolaModificatore(forza);
            Console.WriteLine($"(Modificatore: {(modificatoreForza >= 0 ? $"+{modificatoreForza}" : $"{modificatoreForza}")})");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inserisci la Destrezza  di {nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int destrezza = LeggiInputInteroValido();
            Console.ForegroundColor = ConsoleColor.Green;
            int modificatoreDestrezza = CalcolaModificatore(destrezza);
            Console.WriteLine($"(Modificatore: {(modificatoreDestrezza >= 0 ? $"+{modificatoreDestrezza}" : $"{modificatoreDestrezza}")})");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inserisci la Costituzione  di {nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int costituzione = LeggiInputInteroValido();
            Console.ForegroundColor = ConsoleColor.Green;
            int modificatoreCostituzione = CalcolaModificatore(costituzione);
            Console.WriteLine($"(Modificatore: {(modificatoreCostituzione >= 0 ? $"+{modificatoreCostituzione}" : $"{modificatoreCostituzione}")})");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inserisci l'Intelligenza  di {nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int intelligenza = LeggiInputInteroValido();
            Console.ForegroundColor = ConsoleColor.Green;
            int modificatoreIntelligenza = CalcolaModificatore(intelligenza);
            Console.WriteLine($"(Modificatore: {(modificatoreIntelligenza >= 0 ? $"+{modificatoreIntelligenza}" : $"{modificatoreIntelligenza}")})");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inserisci la Saggezza  di {nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int saggezza = LeggiInputInteroValido();
            Console.ForegroundColor = ConsoleColor.Green;
            int modificatoreSaggezza = CalcolaModificatore(saggezza);
            Console.WriteLine($"(Modificatore: {(modificatoreSaggezza >= 0 ? $"+{modificatoreSaggezza}" : $"{modificatoreSaggezza}")})");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inserisci il Carisma di {nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int carisma = LeggiInputInteroValido();
            Console.ForegroundColor = ConsoleColor.Green;
            int modificatoreCarisma = CalcolaModificatore(carisma);
            Console.WriteLine($"(Modificatore: {(modificatoreCarisma >= 0 ? $"+{modificatoreCarisma}" : $"{modificatoreCarisma}")})");

            Console.ResetColor();
            Console.WriteLine("\n══════════════════════════════════════════════════════\n");

            // Creazione del personaggio
            Personaggio p = new Personaggio(nome, razza, sottoRazza, classe, sottoClasse, background, allineamento1, livello, puntiVita,forza, destrezza, costituzione, intelligenza, saggezza, carisma);

            // Calcolo dei punti vita con i bonus
            p.CalcolaPuntiVitaConBonus();

            p.GetLingua();

            //p.GetCompetenza();
            p.ScegliCompetenze( nome, classe);
            p.ScegliEquipaggiamento(nome, classe);

            p.SetLingue();

            p.TagliaPersonaggio();
            // Stampa dei dettagli del personaggio
            p.StampaPersonaggio();

            // Attendi l'input dell'utente prima di chiudere la console
            Console.ReadLine();
        }

        // Metodo per calcolare il modificatore
        public static int CalcolaModificatore(int punteggio)
        {
            return (punteggio - 10) / 2;
        }

        // Metodo per leggere e validare input intero
        public static int LeggiInputInteroValido()
        {
            int risultato;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out risultato))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inserisci un numero intero valido:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                input = Console.ReadLine();
            }
            return risultato;
        }

    }
}
