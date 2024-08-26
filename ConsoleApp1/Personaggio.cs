using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public enum Razza
    {
        Umano, Nano, Elfo, Mezzelfo, Mezzorco, Halfling, Gnomo, Tiefling, Dragonide
    }

    public enum SottoRazza
    {
        Nessuna, ElfoAlto, ElfoSilvano, Drow, NanodiMontagna, NanodiCollina, Duergar,
        piedelesto, vigoroso, GnomodellForeste, GnomodelleRocce, Argento, Bronzo, Ottone, Rame, Oro,
        Bianco, Blu, Nero, Rosso, Verde, Tiefling
    }

    public enum Classe
    {
        Barbaro, Bardo, Chierico, Druido, Guerriero, Ladro, Mago, Monaco, Paladino, Ranger, Stregone, Warlock
    }

    public enum Sottoclasse
    {    
        Nessuna, 
        //Barbaro
        Berserker, GuerrieroTotemico, 
        //Bardo
        CollegioDellaConoscenza, CollegioDelValore,
        //Chierico
        DominioDellaConoscenza, DominioDellaVita, DominioDellaLuce, DominioDellaNatura,
        DominioDellaTempesta, DominioDellInganno, DominioDellaGuerra, 
        //Druido
        CircoloDellaTerra, CircoloDellaLuna,
        Campione, MaestroDiBattaglia, CavaliereMistico, 
        //Ladro
        Furfante, Assassino, MistificatoreArcano,
        //Mago
        ScuolaDiAbiurazione, ScuolaDiAmmaliamento, ScuolaDiDivinazione, ScuolaDiEvocazione,
        ScuolaDiIllusione, ScuolaDiInvocazione, ScuolaDiNecromanzia, ScuolaDiTrasmutazione, 
        //Monaco
        ViaDellaManoAperta, ViaDellOmbra, ViaDeiQuattroElementi, 
        //Paladino
        GiuramentoDellaDevozione, GiuramentoDegliAntichi, GiuramentoDellaVendetta,
        //Ranger
        Cacciatore, MaestroDelleBestie, 
        //Stregone
        MagiaSelvaggia, DiscendenteDraconico, 
        //Warlock
        PattoDellaCatena, PattoDellaLama, PattoDelTomo
    }




    public enum Background
    {
        Accolito, Ciarlatano, Criminale, Intrattenitore, EroePopolare, ArtigianoDiGilda, Eremita, Nobile, Esploratore,
        Sapiente, Marinaio, Soldato, Monello
    }

    public enum Allineamento
    {
        Buono, Neutrale, Malvagio, LegaleBuono, NeutraleBuono, CaoticoBuono, LegaleNeutrale, NeutralePuro, CaoticoNeutrale, LegaleMalvagio, NeutraleMalvagio, CaoticoMalvagio
    }

    public class Personaggio
    {
        private Razza razza;
        private SottoRazza sottoRazza;
        private Classe classe;
        private Sottoclasse sottoClasse;
        private Background background;
        private Allineamento allineamento;

        public string Nome { get; set; }
        public Razza RazzaPersonaggio { get; set; }
        public SottoRazza SottoRazzaPersonaggio { get; set; }
        public Classe ClassePersonaggio { get; set; }
        public Sottoclasse SottoclassePersonaggio { get; set; }
        public Background BackgroundPersonaggio { get; set; }
        public Allineamento AllineamentoPersonaggio{ get; set; }
        public int Livello { get; set; }
        public int PuntiVita { get; set; }
        public List<string> LingueParlate { get; set; } = new List<string>();
        public string LinguaAggiuntiva { get; set; }
        public int Forza { get; set; }
        public int Destrezza { get; set; }
        public int Costituzione { get; set; }
        public int Intelligenza { get; set; }
        public int Saggezza { get; set; }
        public int Carisma { get; set; }



        public Personaggio(string nome, Razza razza, SottoRazza sottoRazza, Classe classe, Sottoclasse sottoClasse, Background background, Allineamento allineamento, int livello, int puntiVita, int forza, int destrezza, int costituzione, int intelligenza, int saggezza, int carisma)
        {
            Nome = nome;
            RazzaPersonaggio = razza;
            SottoRazzaPersonaggio = sottoRazza;
            ClassePersonaggio = classe;
            SottoclassePersonaggio= sottoClasse;
            BackgroundPersonaggio = background;
            AllineamentoPersonaggio = allineamento;
            Livello = livello;
            PuntiVita = puntiVita;
            Forza = forza;
            Destrezza = destrezza;
            Costituzione = costituzione;
            Intelligenza = intelligenza;
            Saggezza = saggezza;
            Carisma = carisma;
        }

        public void CalcolaPuntiVitaConBonus()
        {
            // Applicazione dei bonus razziali prima del calcolo dei punti vita
            switch (RazzaPersonaggio)
            {
                case Razza.Umano:
                    Forza += 1;
                    Destrezza += 1;
                    Costituzione += 1;
                    Intelligenza += 1;
                    Saggezza += 1;
                    Carisma += 1;
                    break;

                case Razza.Nano:
                    Costituzione += 2; // Bonus Costituzione base per i nani
                    if (SottoRazzaPersonaggio == SottoRazza.NanodiMontagna)
                    {
                        Forza += 2;
                    }
                    else if (SottoRazzaPersonaggio == SottoRazza.NanodiCollina)
                    {
                        Saggezza += 1;
                        Costituzione += 1; // Bonus aggiuntivo di Costituzione per i nani delle colline
                        PuntiVita += Livello; // 1 punto vita extra per livello
                    }
                    break;

                case Razza.Elfo:
                    Destrezza += 2;
                    if (SottoRazzaPersonaggio == SottoRazza.ElfoAlto)
                    {
                        Intelligenza += 1;
                    }
                    else if (SottoRazzaPersonaggio == SottoRazza.ElfoSilvano)
                    {
                        Saggezza += 1;
                    }
                    break;

                case Razza.Mezzelfo:
                    Carisma += 2;
                    // Aggiungi altri bonus se necessari
                    break;

                case Razza.Mezzorco:
                    Forza += 2;
                    Costituzione += 1;
                    break;

                case Razza.Halfling:
                    Destrezza += 2;
                    // Aggiungi altri bonus se necessari
                    break;

                case Razza.Gnomo:
                    Intelligenza += 2;
                    // Aggiungi altri bonus se necessari
                    break;

                case Razza.Tiefling:
                    Carisma += 2;
                    Intelligenza += 1;
                    break;

                case Razza.Dragonide:
                    Forza += 2;
                    Carisma += 1;
                    break;
            }




            // Ora calcola i punti vita in base alla classe
            switch (ClassePersonaggio)
            {
                case Classe.Barbaro:
                    if (Livello > 1)
                    {
                        PuntiVita += 7 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 12 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Bardo:
                    if (Livello > 1)
                    {

                        PuntiVita += 5 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 8 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Chierico:
                    if (Livello > 1)
                    {

                        PuntiVita += 5 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 8 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Guerriero:
                    if (Livello > 1)
                    {

                        PuntiVita += 6 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 10 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Ladro:
                    if (Livello > 1)
                    {

                        PuntiVita += 5 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 8 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Mago:
                    if (Livello > 1)
                    {

                        PuntiVita += 4 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 6 + CalcolaModificatore(Costituzione);
                    }
                    break;

                default:
                    throw new Exception("Classe non supportata");
            }
        }



        // Inizializza il dizionario delle sottoclassi per classe
       

        public string TagliaPersonaggio()
        {
            if (RazzaPersonaggio == Razza.Halfling || RazzaPersonaggio == Razza.Gnomo)
            {
                return "Piccola";
            }
            else
            {
                return "Media";
            }
        }

        public int ScuroVisione()

        {
            if (RazzaPersonaggio == Razza.Elfo)
            {
                return 18;
            }

            else if (RazzaPersonaggio == Razza.Mezzelfo)
            {
                return 18;
            }

            else if (RazzaPersonaggio == Razza.Tiefling)
            {
                return 18;
            }
            else if (RazzaPersonaggio == Razza.Mezzorco)
            {
                return 18;
            }

            else if (RazzaPersonaggio == Razza.Gnomo)
            {
                return 18;
            }

            else if (SottoRazzaPersonaggio == SottoRazza.Drow)
            {
                return 36;
            }
            else if (RazzaPersonaggio == Razza.Nano)
            {
                return 18;
            }

            else if (SottoRazzaPersonaggio == SottoRazza.Duergar)
            {
                return 36;
            }

            else
            {
                return 0;

            }

        }



        public double VelocitaPersonaggio()
        {
            if (RazzaPersonaggio == Razza.Gnomo || RazzaPersonaggio == Razza.Nano || RazzaPersonaggio == Razza.Halfling)
            {
                return 7.5;
            }

            else
            {
                return 9;
            }

        }

        public int CalcolaModificatore(int punteggio)
        {
            return (punteggio - 10) / 2;
        }

        public void SetLingue()
        {
            // Ottieni la lingua di default in base alla razza
            LingueParlate.Add(GetLingua());

            // Se la razza è Umano o Mezzelfo, permetti di scegliere una lingua aggiuntiva
            if (RazzaPersonaggio == Razza.Umano || RazzaPersonaggio == Razza.Mezzelfo)
            {
                ScegliLinguaAggiuntiva();
            }

            // Stampa le lingue conosciute
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("Lingue conosciute dal personaggio:");
            //Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var lingua in LingueParlate)
            {
                //Console.WriteLine(lingua);
            }
            Console.ResetColor();
        }

        // Metodo per scegliere una lingua aggiuntiva
        private void ScegliLinguaAggiuntiva()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scegli una lingua aggiuntiva oltre a quella di default:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            LinguaAggiuntiva = Console.ReadLine();

            // Aggiunge la lingua aggiuntiva alla lista delle lingue parlate
            if (!string.IsNullOrEmpty(LinguaAggiuntiva))
            {
                LingueParlate.Add(LinguaAggiuntiva);
            }
            Console.ResetColor();
        }

        public string GetLingua()
        {
            switch (RazzaPersonaggio)
            {
                case Razza.Umano:
                case Razza.Mezzelfo:
                    return "Comune";
                case Razza.Elfo:
                    return "Elfico,Comune";
                case Razza.Gnomo:
                    return "Gnomesco,Comune ";
                case Razza.Halfling:
                    return "Halfling Comune";
                case Razza.Nano:
                    return "Nanico, Comune";
                case Razza.Tiefling:
                    return "Infernale, Comune";
                case Razza.Dragonide:
                    return "Draconico, Comune";
                case Razza.Mezzorco:
                    return "Orchesco, Comune";
                default:
                    return "Nessun_Linguaggio";
            }
        }

        //private void ScegliLinguaAggiuntiva()
        //{
        //    if (RazzaPersonaggio == Razza.Umano || RazzaPersonaggio == Razza.Mezzelfo)
        //    {
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("Scegli una lingua aggiuntiva oltre a quella di default:");
        //        Console.ForegroundColor = ConsoleColor.Cyan;
        //        LinguaAggiuntiva = Console.ReadLine();

        //        // Aggiunge la lingua aggiuntiva alla lista delle lingue parlate
        //        if (!string.IsNullOrEmpty(LinguaAggiuntiva))
        //        {
        //            LingueParlate.Add(LinguaAggiuntiva);
        //        }
        //    }
        //    Console.ResetColor();
        //}


        public void StampaPersonaggio()
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Calcola la larghezza del bordo in base alla lunghezza massima della riga
            int borderWidth = 50; // Puoi modificare la larghezza a seconda delle tue preferenze

            // Funzione per creare una riga con bordo
            string BorderLine() => new string('═', borderWidth);

            // Funzione per stampare una riga con bordi laterali
            void PrintLine(string content)
            {
                Console.WriteLine($"║ {content.PadRight(borderWidth - 2)} ║");
            }

            // Funzione per stampare il titolo con bordo superiore e inferiore
            void PrintTitle(string title)
            {
                Console.WriteLine($"╔{BorderLine()}╗");
                PrintLine(title);
                Console.WriteLine($"╚{BorderLine()}╝");
            }

            // Stampa il titolo
            PrintTitle("Scheda Personaggio");

            // Stampa le informazioni del personaggio
            PrintLine($"Nome: {Nome}");
            PrintLine($"Razza: {RazzaPersonaggio}");
            PrintLine($"Taglia: {TagliaPersonaggio()}");
            PrintLine($"Velocità: {VelocitaPersonaggio()} metri");
            PrintLine($"Scurovisione: {ScuroVisione()} metri");
            PrintLine($"Linguaggi: {GetLingua()}");
            PrintLine($"Sottorazza: {SottoRazzaPersonaggio}");
            PrintLine($"Classe: {ClassePersonaggio}");
            PrintLine($"Sottoclasse: {SottoclassePersonaggio}");
            PrintLine($"Background: {BackgroundPersonaggio}");
            PrintLine($"Allineamento: {AllineamentoPersonaggio}");
            PrintLine($"Livello: {Livello}");
            PrintLine($"Punti Vita: {PuntiVita}");

            // Funzione per aggiungere il segno +
            string FormatWithSign(int value) => value >= 0 ? $"+{value}" : value.ToString();

            // Stampa le caratteristiche con il loro modificatore
            PrintLine($"Forza: {FormatWithSign(Forza)}");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLine($"Forza (Modificatore): {FormatWithSign((Forza - 10) / 2)}");
            Console.ForegroundColor = ConsoleColor.White;
            PrintLine($"Destrezza: {FormatWithSign(Destrezza)}");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLine($"Destrezza (Modificatore): {FormatWithSign((Destrezza - 10) / 2)}");
            Console.ForegroundColor = ConsoleColor.White;
            PrintLine($"Costituzione: {FormatWithSign(Costituzione)}");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLine($"Costituzione (Modificatore): {FormatWithSign((Costituzione - 10) / 2)}");
            Console.ForegroundColor = ConsoleColor.White;
            PrintLine($"Intelligenza: {FormatWithSign(Intelligenza)}");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLine($"Intelligenza (Modificatore): {FormatWithSign((Intelligenza - 10) / 2)}");
            Console.ForegroundColor = ConsoleColor.White;
            PrintLine($"Saggezza: {FormatWithSign(Saggezza)}");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLine($"Saggezza (Modificatore): {FormatWithSign((Saggezza - 10) / 2)}");
            Console.ForegroundColor = ConsoleColor.White;
            PrintLine($"Carisma: {FormatWithSign(Carisma)}");
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLine($"Carisma (Modificatore): {FormatWithSign((Carisma - 10) / 2)}");
            Console.ForegroundColor = ConsoleColor.White;

            // Aggiungi la stampa delle lingue conosciute dal personaggio
            Console.WriteLine($"╠{BorderLine()}╣"); // Aggiungi una linea di separazione se necessario
            Console.ForegroundColor = ConsoleColor.White;
            PrintLine("Lingue conosciute dal personaggio:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var lingua in LingueParlate)
            {
                PrintLine(lingua); // Usa PrintLine per mantenere il formato con i bordi
            }
            Console.ForegroundColor = ConsoleColor.White;


            // Stampa il bordo inferiore
            Console.WriteLine($"╚{BorderLine()}╝");

            // Ripristina il colore del testo predefinito
            Console.ResetColor();
        }
    }
}