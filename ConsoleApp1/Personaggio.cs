using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    public enum Razza
    {
        Umano, Nano, Elfo, Mezzelfo, Mezzorco, Halfling, Gnomo, Tiefling, Dragonide
    }

    public enum SottoRazza
    {
        Nessuna,
        //Elfo
        ElfoAlto, ElfoSilvano, Drow,
        //Nano
        NanodiMontagna, NanodiCollina, Duergar,
        //Halfling
        Piedelesto, Vigoroso,
        //Gnomo
        GnomodellForeste, GnomodelleRocce,
        //Dragonide
        Argento, Bronzo, Ottone, Rame, Oro,
        Bianco, Blu, Nero, Rosso, Verde,
        //Tiefling

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

        //Guerriero
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
        Accolito, ArtigianoDiGilda, Ciarlatano, Criminale, Eremita, EroePopolare, Forestiero, Intrattenitore, Marinaio, Monello, Nobile, Sapiente, Soldato
    }

    public enum Allineamento
    {
        Buono, Neutrale, Malvagio, LegaleBuono, NeutraleBuono, CaoticoBuono, LegaleNeutrale, NeutralePuro, CaoticoNeutrale, LegaleMalvagio, NeutraleMalvagio, CaoticoMalvagio
    }

    public enum Competenze
    { //Skills
        Atletica,
        Acrobazia,
        Furtività,
        Rapidità_di_Mano,
        Arcano,
        Storia,
        Indagare,
        Natura,
        Religione,
        Addestrare_Animali,
        Intuizione, Medicina,
        Percezione,
        Sopravvivenza,
        Inganno, Intimidire,
        Persuasione,
        Intrattenere,

    }

    public enum Equipaggiamento
    {
        //
        Nessuna,
        //Armature Leggere
        Armatura_Di_Cuoio,
        Armatura_Di_Cuoio_Borchiato,
        Armatura_Imbottita,

        // Armature Medie
        Armatura_Di_Pelle,
        Giaco_Di_Maglia,
        Corazza_Di_Scaglie,
        Armatura_Di_Piastre,
        Mezza_Armatura,

        // Armature Pesanti
        Corazza_ad_Anelli,
        Cotta_Di_Maglia,
        Corazza_a_Strisce,
        Armatura_Completa,


        //Scudi
        Scudo,


        //Dotazioni
        Dotazione_da_espolaratore,
        Dotazione_da_diplomatico,
        Dotazione_da_studioso,
        Dotazione_da_sacerdote,



        //Armi Semplici


        Ascia,
        Bastone_Ferrato,
        Falcetto,
        Giavellotto,
        Lancia,
        Martello_Leggero,
        Mazza,
        Pugnale,
        Randello,
        Randello_Pesante,
        Arco_Corto,
        Balestra_Leggera,
        Fionda,

        // Armi da Guerra
        Spada_Corta,
        Spada_Lunga,
        Scimitarra,
        Spadone,

        Martello,
        Martello_da_guerra,
        Mazzafrusto,
        Bastone,

        // Archi

        Arco_Lungo,
        Arco_Corto_Composito,
        Arco_Lungo_Composito,

        // Balestre

        Balestra_Pesante,
        Balestra_a_Mano,
        Balestra_da_Assedio,

        // Munizioni
        Dardo,
        Freccia
    }

    public enum Strumenti_Musicali
    {
        Arpa,
        Cornamusa,
        Flauto,
        Liuto,
        Tamburo,
        Violino
    }

    public class Personaggio
    {
        private Razza razza;
        private SottoRazza sottoRazza;
        private Classe classe;
        private Sottoclasse sottoClasse;
        private Background background;
        private Allineamento allineamento;
        private Competenze competenze;
        private Equipaggiamento equipaggiamento;


        public string Nome { get; set; }
        public Razza RazzaPersonaggio { get; set; }
        public SottoRazza SottoRazzaPersonaggio { get; set; }
        public Classe ClassePersonaggio { get; set; }
        public Sottoclasse SottoclassePersonaggio { get; set; }
        public Background BackgroundPersonaggio { get; set; }
        public Allineamento AllineamentoPersonaggio { get; set; }
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

        public int Ricchezza { get; set; }


        public Personaggio(string nome, Razza razza, SottoRazza sottoRazza, Classe classe, Sottoclasse sottoClasse, Background background, Allineamento allineamento, int livello, int puntiVita, int forza, int destrezza, int costituzione, int intelligenza, int saggezza, int carisma)
        {
            Nome = nome;
            RazzaPersonaggio = razza;
            SottoRazzaPersonaggio = sottoRazza;
            ClassePersonaggio = classe;
            SottoclassePersonaggio = sottoClasse;
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

                case Classe.Druido:
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

                case Classe.Monaco:
                    if (Livello > 1)
                    {

                        PuntiVita += 5 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 8 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Paladino:
                    if (Livello > 1)
                    {

                        PuntiVita += 6 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 10 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Ranger:
                    if (Livello > 1)
                    {

                        PuntiVita += 6 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 10 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Stregone:
                    if (Livello > 1)
                    {

                        PuntiVita += 4 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 6 + CalcolaModificatore(Costituzione);
                    }
                    break;

                case Classe.Warlock:
                    if (Livello > 1)
                    {

                        PuntiVita += 6 * (Livello - 1) + (Livello - 1) * CalcolaModificatore(Costituzione); // Livelli successivi
                    }
                    else
                    {
                        PuntiVita += 10 + CalcolaModificatore(Costituzione);
                    }
                    break;

                default:
                    throw new Exception("Classe non supportata");
            }
        }






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

        public List<string> Skills { get; set; } = new List<string>();

        public void ScegliCompetenze(string nome, Classe classe)
        {
            if (classe == Classe.Warlock)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Scegli due Skill");
                Console.WriteLine($"Scegli la prima skill di {nome} (Arcano, Storia, Religione, Medicina, Intimidire, Indagare, Furtività, Atletica, Acrobazia):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Arcano, Storia, Religione, Medicina, Intimidire, Indagare, Furtività, Atletica, Acrobazia):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                // Aggiungi le competenze alla lista delle skill
                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
            }

            else if (classe == Classe.Barbaro)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Scegli due Skill");
                Console.WriteLine($"Scegli la prima skill di {nome} (Atletica, Sopravvivenza, Furtività, Intimidire, Natura, Acrobazia):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Atletica, Sopravvivenza, Furtività, Intimidire, Natura, Acrobazia):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);




                // Aggiungi le competenze alla lista delle skill
                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);

            }

            else if (classe == Classe.Bardo)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Scegli Tre Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Acrobazia, Arcano, Atletica, Furtività, Indagare, Inganno, Intimidire, Intuizione, Medicina, Natura, Persuasione, Religione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Acrobazia, Arcano, Atletica, Furtività, Indagare, Inganno, Intimidire, Intuizione, Medicina, Natura, Persuasione, Religione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la terza skill di {nome} (Acrobazia, Arcano, Atletica, Furtività, Indagare, Inganno, Intimidire, Intuizione, Medicina, Natura, Persuasione, Religione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput3 = OttieniCompetenzaValida(competenzaInput2);

                // Aggiungi le competenze alla lista delle skill
                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
                Skills.Add(competenzaInput3);
            }

            else if (classe == Classe.Chierico)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Scegli Due Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Storia, Religione, Medicina, Intimidire, Indagare, Persuasione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Storia, Religione, Medicina, Intimidire, Indagare, Persuasione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                // Aggiungi le competenze alla lista delle skill
                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
            }

            else if (classe == Classe.Druido)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli Due Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Natura, Sopravvivenza, Religione, Medicina, Indagare, Intuizione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Natura, Sopravvivenza, Religione, Medicina, Indagare, Intuizione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                // Aggiungi le competenze alla lista delle skill
                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
            }

            else if (classe == Classe.Guerriero)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli Due Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Atletica, Sopravvivenza, Furtività, Intimidire, Natura, Acrobazia):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Atletica, Sopravvivenza, Furtività, Intimidire, Natura, Acrobazia):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                // Aggiungi le competenze alla lista delle skill
                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
            }

            else if (classe == Classe.Ladro)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la prima skill di {nome} (Acrobazia, Furtività, Rapidità_di_Mano, Indagare, Inganno, Intimidire, Investigare, Percezione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} Acrobazia, Furtività, Rapidità_di_Mano, Indagare, Inganno, Intimidire, Investigare, Percezione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la terza skill di {nome} (Acrobazia, Furtività, Rapidità_di_Mano, Indagare, Inganno, Intimidire, Investigare, Percezione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput3 = OttieniCompetenzaValida(competenzaInput1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la quarta skill di {nome} (Acrobazia, Furtività, Rapidità_di_Mano, Indagare, Inganno, Intimidire, Investigare, Percezione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput4 = OttieniCompetenzaValida(competenzaInput1);

                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
                Skills.Add(competenzaInput3);
                Skills.Add(competenzaInput4);

            }

            else if (classe == Classe.Mago)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli Due Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} ( Arcano, Storia, Religione, Medicina, Indagare, Natura):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Arcano, Storia, Religione, Medicina, Indagare, Natura):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
            }

            else if (classe == Classe.Monaco)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli Due Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Acrobazia, Furtività, Atletica, Intimidire, Religione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Acrobazia, Furtività, Atletica, Intimidire, Religione, Sopravvivenza):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);

            }

            else if (classe == Classe.Paladino)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli Due Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Atletica, Intimidire, Religione, Medicina, Persuasione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Atletica, Intimidire, Religione, Medicina, Persuasione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
            }

            else if (classe == Classe.Ranger)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli Tre Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Addestrare_Animali, Atletica, Furtività, Indagare, Natura, Percezione, Sopravvivenza, Religione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Addestrare_Animali, Atletica, Furtività, Indagare, Natura, Percezione, Sopravvivenza, Religione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la terza skill di {nome} (Addestrare_Animali, Atletica, Furtività, Indagare, Natura, Percezione, Sopravvivenza, Religione):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput3 = OttieniCompetenzaValida(competenzaInput2);

                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
                Skills.Add(competenzaInput3);

            }

            else if (classe == Classe.Stregone)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli Due Skills");
                Console.WriteLine($"Scegli la prima skill di {nome} (Arcano, Storia, Religione, Medicina, Indagare, Natura):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput1 = OttieniCompetenzaValida();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la seconda skill di {nome} (Arcano, Storia, Religione, Medicina, Indagare, Natura):");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string competenzaInput2 = OttieniCompetenzaValida(competenzaInput1);

                Skills.Add(competenzaInput1);
                Skills.Add(competenzaInput2);
            }
        }

        private string OttieniCompetenzaValida(string competenzaDaEscludere = null)
        {
            Competenze competenza;
            string input;
            bool competenzaValida;

            do
            {
                input = Console.ReadLine();

                if (!Enum.TryParse(input, true, out competenza) || !Enum.IsDefined(typeof(Competenze), competenza))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Competenza non valida, riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    competenzaValida = false;
                }
                else if (competenza.ToString().Equals(competenzaDaEscludere, StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hai già scelto questa competenza, riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    competenzaValida = false;
                }
                else
                {
                    competenzaValida = true;
                }
            } while (!competenzaValida);

            return competenza.ToString();
        }



        public List<string> Equipaggiamento { get; set; } = new List<string>();

        public void ScegliEquipaggiamento(string nome, Classe classe)
        {
            if (classe == Classe.Barbaro)
            {



                // Selezione arma principale
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) Un'Ascia Bipenne  (b) una qualsiasi arma da guerra da mischia");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput = Console.ReadLine().Trim().ToLower();

                if (armaInput == "a")
                {
                    Equipaggiamento.Add($"Ascia bipenne 1d12(tagliente)+{CalcolaModificatore(Forza)}");
                }

                else if (armaInput == "b")
                {
                    ScegliArmaDaGuerra();

                }



                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}:(a) due asce  o (b) una qualsiasi arma semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string inputarmaSemplice = Console.ReadLine().Trim().ToLower();



                if (inputarmaSemplice == "a")
                {
                    Equipaggiamento.Add("Due asce");
                }
                else if (inputarmaSemplice == "b")
                {
                    ScegliArmaSemplice();
                }

                Equipaggiamento.Add("4 Giacellotti");
                Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                Equipaggiamento.Add("1 Giaciglio");
                Equipaggiamento.Add("1 Gavetta");
                Equipaggiamento.Add("Acciarino e pietra focaia");
                Equipaggiamento.Add("10 Torce");
                Equipaggiamento.Add("10 razioni giornaliere");
                Equipaggiamento.Add("15m di corda");





                Console.ResetColor();

            }

            else if (classe == Classe.Bardo)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) Uno Stocco, (b) Una Spada Lunga (c) Una qualsiasi arma semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput = Console.ReadLine().Trim().ToLower();

                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Stocco");
                }
                else if (armaInput == "b")
                {
                    Equipaggiamento.Add("Spada Lunga");
                }
                else if (armaInput == "c")
                {
                    ScegliArmaSemplice();
                }


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la dotazione di {nome}:(a) una dotazione da diplomatico o (b) una dotazione da intrattenitore");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string inputarmaSemplice = Console.ReadLine().Trim().ToLower();

                if (inputarmaSemplice == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 39).ToString());
                    Equipaggiamento.Add("Zaino");
                    Equipaggiamento.Add("2 Ccustodie per Pergamente");
                    Equipaggiamento.Add("1 Abito Pregiato");
                    Equipaggiamento.Add("1 boccetta di inchiostro");
                    Equipaggiamento.Add("1 Pennino");
                    Equipaggiamento.Add("1 Lampada");
                    Equipaggiamento.Add("2 Ampolle'olio");
                    Equipaggiamento.Add("5 Fogli di Pergamena");
                    Equipaggiamento.Add("1 Sigillo di cera");
                    Equipaggiamento.Add("1 Fiala di profumo");
                    Equipaggiamento.Add("1 Sapone");
                }
                else if (inputarmaSemplice == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 40).ToString());
                    Equipaggiamento.Add("1 Zaino");
                    Equipaggiamento.Add("1 Giaciglio");
                    Equipaggiamento.Add("2 Costumi");
                    Equipaggiamento.Add("5 Candele");
                    Equipaggiamento.Add("5 Razioni Giornaliere");
                    Equipaggiamento.Add("1 Otre");
                    Equipaggiamento.Add("Trucchi per il camuffamento");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli lo strumento musicale di {nome}:(a) un Liuto o (b) un qualasi altro strumento musicale");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string inputstrumento = Console.ReadLine().Trim().ToLower();
                if (inputstrumento == "a")
                {
                    Equipaggiamento.Add("Liuto");
                }
                else if (inputstrumento == "b")
                {
                    ScegliStrumentoMusicale();
                }

                // Selezione equipaggiamento
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Equipaggiamento.Add("Amatura di cuoio e un pugnale");

                Console.ResetColor();
            }


            else if (classe == Classe.Chierico)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) Una Mazza, o (b) Martello se competente");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput = Console.ReadLine().Trim().ToLower();

                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Mazza");
                }
                else if (armaInput == "b")
                {
                    Equipaggiamento.Add("Martello da guerra");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'armatura  di {nome}:(a) una Corazza di Scaglie (b) un'armatura di cuoio, (c) una cotta di maglia");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string inputAmrmatura = Console.ReadLine().Trim().ToLower();

                if (inputAmrmatura == "a")
                {
                    Equipaggiamento.Add("Corazza di Scaglie");
                }
                else if (inputAmrmatura == "b")
                {
                    Equipaggiamento.Add("Armatura di Cuoio");
                }
                else if (inputAmrmatura == "c")
                {
                    Equipaggiamento.Add("Cotta di Maglia");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) Una Balestra leggera e 20 quadrelli o (b) Una qualsiasi Arma Semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string inputarma1 = Console.ReadLine().Trim().ToLower();
                if (inputarma1 == "a")
                {
                    Equipaggiamento.Add("Balestra leggera e 20quad.");
                }
                else if (inputarma1 == "b")
                {
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) Una Dotazione da Sarcerdote (b) Dotazione da Esploratore");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string inputdotazione = Console.ReadLine().Trim().ToLower();
                if (inputdotazione == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 19).ToString());
                    Equipaggiamento.Add("Zaino");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("1 coperta");                   
                    Equipaggiamento.Add("1 Cassetta per le offerte");
                    Equipaggiamento.Add("1 Veste");
                    Equipaggiamento.Add("2 incenso e incensiere");
                    Equipaggiamento.Add("2 razioni giornaliere");
                    Equipaggiamento.Add("1 Otre");
                    Equipaggiamento.Add("10 Candele");

                }
                else if (inputdotazione == "b")

                {
                    Equipaggiamento.Add((GetRicchezza() + 10).ToString());
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("15m di corda");
                    Equipaggiamento.Add("1 Giaciglio");
                    Equipaggiamento.Add("1 Gavetta");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                   

                }


                Equipaggiamento.Add("Scudo e un simbolo sacro");

                Console.ResetColor();
            }



            else if (classe == Classe.Druido)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) Uno scudo di legno o, (b) Una qualsiasi Arma Semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput = Console.ReadLine().Trim().ToLower();

                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Scudo di legno");
                }

                else if (armaInput == "b")
                {
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma secondaria di {nome}: (a) una Scimitarra (b) Una qualsiasi arma semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput1 = Console.ReadLine().Trim().ToLower();
                if (armaInput1 == "a")
                {
                    Equipaggiamento.Add("Armatura di Cuoio");
                }
                else if (armaInput1 == "b")
                {
                    ScegliArmaSemplice();
                }


                Equipaggiamento.Add((GetRicchezza() + 10).ToString());
                Equipaggiamento.Add("1 Giaciglio");
                Equipaggiamento.Add("1 Gavetta");
                Equipaggiamento.Add("Acciarino e pietra focaia");
                Equipaggiamento.Add("10 Torce");
                Equipaggiamento.Add("10 razioni giornaliere");
                Equipaggiamento.Add("15m di corda");
                Equipaggiamento.Add("Focus Druidico");
                Equipaggiamento.Add("Armatura di cuioio");

            }

            else if (classe == Classe.Guerriero)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'armatura per {nome}: (a) cotta di maglia o (b) armatura di cuoio e arco lungo");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaturaInput = Console.ReadLine().Trim().ToLower();
                if (armaturaInput == "a")
                {
                    Equipaggiamento.Add("Cotta di Maglia");
                }
                else if (armaturaInput == "b")
                {
                    Equipaggiamento.Add("Armatura di cuoio e arco lungo");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Equipaggia: (a) un’arma da guerra e uno scudo o (b) due armi da guerra");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput = Console.ReadLine().Trim().ToLower();
                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Arma da guerra");
                    Equipaggiamento.Add("Scudo");
                }
                else if (armaInput == "b")
                {
                    Equipaggiamento.Add("Due armi da guerra");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Balestra leggera e 20 quadrelli o (b) due Asce");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput1 = Console.ReadLine().Trim().ToLower();

                if (armaInput1 == "a")
                {
                    Equipaggiamento.Add("Balestra leggera e 20 quadrelli");
                }

                else if (armaInput1 == "b")
                {
                    Equipaggiamento.Add("Due asce");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Dotazione da Avventuriero o (b) una Dotazione da Esploratore");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();

                if (equipaggiamentoInput == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 12).ToString());
                    Equipaggiamento.Add("1 Piede di Porco");
                    Equipaggiamento.Add("10 Chiodi da rocciatore");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corsa");

                }
                else if (equipaggiamentoInput == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                    Equipaggiamento.Add("1 Giaciglio");
                    Equipaggiamento.Add("1 Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda"); ;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Vuoi equipaggiare lo scudo a {nome}? y/n:");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string scudoInput = Console.ReadLine().Trim().ToLower();
                if (scudoInput == "y" && !Equipaggiamento.Contains("Scudo"))
                {
                    Equipaggiamento.Add("Scudo");
                }

                Console.ResetColor();
            }

            else if (classe == Classe.Ladro)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}:(a) uno stocco o (b) una spada corta");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput = Console.ReadLine().Trim().ToLower();
                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Stocco");
                }
                else if (armaInput == "b")
                {
                    Equipaggiamento.Add("Spada Corta");
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli: (a) Un Arco Corto e una Feretra con 20fr. o (b) una Spada Corta");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput1 = Console.ReadLine().Trim().ToLower();
                if (armaInput1 == "a")
                {
                    Equipaggiamento.Add("Un Arco Corto e una Feretra con 20fr.");

                }
                else if (armaInput1 == "b")
                {
                    Equipaggiamento.Add("Spada Corta");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli: (a) Dotazione da Scassinatore o (b) una Dotazione da avventuriero, (c) una Dotazione da Esploratore");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();

                if (equipaggiamentoInput == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 16).ToString() + "MO");
                    Equipaggiamento.Add("1000 sfere metalliche");
                    Equipaggiamento.Add("3m di spago");
                    Equipaggiamento.Add("1 campanella");
                    Equipaggiamento.Add("5 candele");
                    Equipaggiamento.Add("1 piede di porco");
                    Equipaggiamento.Add("Un Martello");
                    Equipaggiamento.Add("10 Chiodi da rocciatore");
                    Equipaggiamento.Add("Una Lanterna Schermabile");
                    Equipaggiamento.Add("2 Ampolle d'olio");
                    Equipaggiamento.Add("5 Razioni giornaliere");
                    Equipaggiamento.Add("Acciarinoe e pietra focaia");
                    Equipaggiamento.Add("15m di corda");
                }

                else if (equipaggiamentoInput == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 12).ToString() + "MO");
                    Equipaggiamento.Add("1 Piede di Porco");
                    Equipaggiamento.Add("10 Chiodi da rocciatore");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corsa");
                }

                else if (equipaggiamentoInput == "c")
                {
                    Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");
                }

                Console.ResetColor();

                Equipaggiamento.Add("Armatura di cuoio");
                Equipaggiamento.Add("Due pugnali");
                Equipaggiamento.Add("Arnesi da Scasso");

            }



            else if (classe == Classe.Mago)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Nessuna Amatura");
                Console.ForegroundColor = ConsoleColor.Cyan;


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) Un Bastone Ferrato (b) Un Pugnale");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput = Console.ReadLine().Trim().ToLower();

                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Bastone Ferrato");
                }
                else if (armaInput == "b")
                {
                    Equipaggiamento.Add("Un Pugnale");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli: (a) una Borsa per Componenti o (b) un Focus Arcano");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string focusInput = Console.ReadLine().Trim().ToLower();
                if (focusInput == "a")
                {
                    Equipaggiamento.Add("Borsa per Componenti");
                }
                else if (focusInput == "b")
                {
                    ScegliFocusArcano();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli la Dotazione di {Nome} (a)  (b)");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string armaInput1 = Console.ReadLine().Trim().ToLower();
                if (armaInput1 == "a")
                {
                    Equipaggiamento.Add("Balestra Leggera e 20 quadrelli");
                }
                else if (armaInput1 == "b")
                {
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Dotazione da Esploratore o (b) una Dotazione da Avventuriero");
                Console.ForegroundColor = ConsoleColor.Cyan;

                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();
                if (equipaggiamentoInput == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");

                }

                else if (equipaggiamentoInput == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 12).ToString() + "MO");
                    Equipaggiamento.Add("1 Piede di Porco");
                    Equipaggiamento.Add("10 Chiodi da rocciatore");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");

                }



                Equipaggiamento.Add("Veste da Mago");
                Equipaggiamento.Add("libro degli incantesimi");

            }

            else if (classe == Classe.Monaco)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) Una Spada Corta (b) Una qualsiasi arma semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput = Console.ReadLine().Trim().ToLower();
                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Spada Corta");
                }
                else if (armaInput == "b")
                {
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) Una Dotazione da avventuriero (b) Una Dotazione da espoloratore");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();
                if (equipaggiamentoInput == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 12).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");

                }
                else if (equipaggiamentoInput == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");

                }

                Equipaggiamento.Add("10 Dardi");


            }

            else if (classe == Classe.Paladino)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) 1arma da Guerra e uno scudo (b) 2 Armi da Guerra");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput = Console.ReadLine().Trim().ToLower();
                if (armaInput == "a")
                {
                    ScegliArmaDaGuerra();
                    Equipaggiamento.Add("Scudo");
                }
                else if (armaInput == "b")
                {
                    ScegliArmaDaGuerra();
                    ScegliArmaDaGuerra();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) 5 Giavellotti (b) 1 Qualsiasi arma arma semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput1 = Console.ReadLine().Trim().ToLower();
                if (armaInput1 == "a")
                {
                    Equipaggiamento.Add("5 Giavellotti");
                }
                else if (armaInput1 == "b")
                {
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Dotazione da Sacerdote o (b) una Dotazione da Esploratore");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();
                if (equipaggiamentoInput == "a")
                {

                    Equipaggiamento.Add((GetRicchezza() + 19).ToString() + "MO");
                    Equipaggiamento.Add("Zaino");
                    Equipaggiamento.Add("1 coperta");
                    Equipaggiamento.Add("10 Candele");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("1 Cassetta per le offerte");
                    Equipaggiamento.Add("1Veste");
                    Equipaggiamento.Add("2 incenso e incensiere");
                    Equipaggiamento.Add("2 razioni giornaliere");
                    Equipaggiamento.Add("1 Otre");
                }
                else if (equipaggiamentoInput == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");

                }
                Equipaggiamento.Add("Armatura di piastre");
                Equipaggiamento.Add("Simbolo sacro");

            }

            else if (classe == Classe.Ranger)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'armatura di {nome}: (a) 1 Corazza di scaglie (b) Un'armatura di cuoio");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput = Console.ReadLine().Trim().ToLower();
                if (armaInput == "a")
                {

                    Equipaggiamento.Add("Corazza di Scaglie");
                }
                else if (armaInput == "b")
                {
                    Equipaggiamento.Add("Armatura di Cuoio");

                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli le armi di {Nome} (a) 2 Spade Corte (b) Due Armi Semplici");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput1 = Console.ReadLine().Trim().ToLower();
                if (armaInput1 == "a")
                {
                    Equipaggiamento.Add("2 Spade Corte");
                }
                else if (armaInput1 == "b")
                {
                    ScegliArmaSemplice();
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) 1 Dotazione da Avventuriero (b) 1 Dotazione da Esploratore ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();
                if (equipaggiamentoInput == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 12).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");


                }
                else if (equipaggiamentoInput == "b")
                {

                    Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");


                }

                Equipaggiamento.Add("Arco Lungo e 20 Frecce");
            }

            else if (classe == Classe.Stregone)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) Una Balestra leggera e 20 Quadrelli (b) Una qualsiasi arma semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput = Console.ReadLine().Trim().ToLower();
                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Balestra leggera e 20 Quadrelli");
                }
                else if (armaInput == "b")
                {
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Borsa per Componenti o (b) un Focus Arcano");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string focusInput = Console.ReadLine().Trim().ToLower();
                if (focusInput == "a")
                {
                    Equipaggiamento.Add("Borsa per Componenti");
                }
                else if (focusInput == "b")
                {
                    ScegliFocusArcano();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Dotazione da Esploratore o (b) una Dotazione da Avventuriero");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();
                if (equipaggiamentoInput == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
                    Equipaggiamento.Add("Un Giaciglio");
                    Equipaggiamento.Add("Una Gavetta");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");
                }
                else if (equipaggiamentoInput == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 12).ToString() + "MO");
                    Equipaggiamento.Add("1 Piede di Porco");
                    Equipaggiamento.Add("10 Chiodi da rocciatore");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");
                }

                Equipaggiamento.Add("2 pugnali");


            }

            else if (classe == Classe.Warlock)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli l'arma di {nome}: (a) 1 Balestra leggera 20 Frecce (b) Una qualsiasi arma semplice");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string armaInput = Console.ReadLine().Trim().ToLower();
                if (armaInput == "a")
                {
                    Equipaggiamento.Add("Arco Corto e 20 Frecce");
                }
                else if (armaInput == "b")
                {
                    ScegliArmaSemplice();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Borsa per Componenti o (b) un Focus Arcano");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string focusInput = Console.ReadLine().Trim().ToLower();
                if (focusInput == "a")
                {
                    Equipaggiamento.Add("Borsa per Componenti");
                }
                else if (focusInput == "b")
                {
                    ScegliFocusArcano();
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Scegli (a) una Dotazione da Studioso o (b) una Dotazione da Avventuriero");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string equipaggiamentoInput = Console.ReadLine().Trim().ToLower();
                if (equipaggiamentoInput == "a")
                {
                    Equipaggiamento.Add((GetRicchezza() + 40).ToString() + "MO");
                    Equipaggiamento.Add("Zaino");
                    Equipaggiamento.Add("1 Libro");
                    Equipaggiamento.Add("1 Boccetta di inchiostro");
                    Equipaggiamento.Add("1 Pennino");
                    Equipaggiamento.Add("10 Fogli di Pergamena");
                    Equipaggiamento.Add("1 Sacchetto di sabbia");
                    Equipaggiamento.Add("1 Coltellino");

                }
                else if (equipaggiamentoInput == "b")
                {
                    Equipaggiamento.Add((GetRicchezza() + 12).ToString() + "MO");
                    Equipaggiamento.Add("1 Piede di Porco");
                    Equipaggiamento.Add("10 Chiodi da rocciatore");
                    Equipaggiamento.Add("10 Torce");
                    Equipaggiamento.Add("Acciarino e pietra focaia");
                    Equipaggiamento.Add("10 razioni giornaliere");
                    Equipaggiamento.Add("15m di corda");

                }

                Equipaggiamento.Add("Armatura di cuoio");
                Equipaggiamento.Add("2 pugnali");
                ScegliArmaSemplice();

            }

        }


        private string OttieniEquipaggiamentoValido()
        {
            Equipaggiamento equipaggiamento;
            string input;
            bool EquipaggiamentoValido;

            do
            {
                input = Console.ReadLine();

                if (!Enum.TryParse(input, true, out equipaggiamento) || !Enum.IsDefined(typeof(Equipaggiamento), equipaggiamento))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Armatura non valida, riprova:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    EquipaggiamentoValido = false;
                }
                else
                {
                    EquipaggiamentoValido = true;
                }
            } while (!EquipaggiamentoValido);

            return equipaggiamento.ToString();
        }



        public void ScegliBGequip(string nome, Background background)
        {
            if (background == Background.Accolito)
            {

                Equipaggiamento.Add("Simbolo sacro");
                Equipaggiamento.Add("Un libro di preghiere");
                Equipaggiamento.Add("5 bastonicini d'incenso");
                Equipaggiamento.Add("vesti");
                Equipaggiamento.Add("1 Abito comune");
                Equipaggiamento.Add((GetRicchezza() + 15).ToString() + "MO");

            }

            else if (background == Background.ArtigianoDiGilda)
            {
                Equipaggiamento.Add("1 Serie di strumenti da artigiano");
                Equipaggiamento.Add("1 Lettera di presentazione della gilda");
                Equipaggiamento.Add("1 Abito da viaggiatore");
                Equipaggiamento.Add((GetRicchezza() + 15).ToString() + "MO");
            }

            else if (background == Background.Ciarlatano)
            {
                Equipaggiamento.Add("1 Abito Pregiato");
                Equipaggiamento.Add("Trucchi per il Camuffamento");
                Equipaggiamento.Add("10 Bottigli con liquido colorato");
                Equipaggiamento.Add("Una serie di dadi truccati");
                Equipaggiamento.Add("1 Mazzo di carte segnate");
                Equipaggiamento.Add("Un anello con simbolo farlocco");
                Equipaggiamento.Add((GetRicchezza()+ 15).ToString() + "MO");
            }

            else if (background == Background.Criminale)
            {
                Equipaggiamento.Add("1 Piede di porco");
                Equipaggiamento.Add("1 Abito comune con cappuccio");
               
                Equipaggiamento.Add((GetRicchezza() + 15).ToString() + "MO");
            }

            else if (background == Background.Eremita)
            {
                Equipaggiamento.Add("Una Custodia per pergamene");
                Equipaggiamento.Add("Una Coperta Invernale");
                Equipaggiamento.Add("1 Abito comune");
                Equipaggiamento.Add("Una Borsa da Erborista");
                Equipaggiamento.Add((GetRicchezza() + 5).ToString() + "MO");
            }

            else if (background == Background.EroePopolare)
            {
                Equipaggiamento.Add("Una serie di strumenti da artigiano");
                Equipaggiamento.Add("1 Pala");
                Equipaggiamento.Add("1 Vaso di Ferro");
                Equipaggiamento.Add("1 Abito comune");
                Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
            }

            else if (background == Background.Forestiero)
            {
                Equipaggiamento.Add("1 Bastone");
                Equipaggiamento.Add("1 Tagliola");
                Equipaggiamento.Add("1 Trofeo di caccia");
                Equipaggiamento.Add("1 Abito da Viaggiatore");
                Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");

            }

            else if (background == Background.Intrattenitore)
            {

                ScegliStrumentoMusicale();
                Equipaggiamento.Add("Il Pegno di un ammiratore");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Scegli uno delle seguenti discilpline d'arte:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("(a) Acrobata (b) Attore (c) Cantore (d) Danzatore");
                Console.WriteLine("(e) Giocoliere (f) Giullare (g) Mangiatore di Fuoco");
                Console.WriteLine("(h) Narratore (i) Poeta (l) Strumentista");

                string disciplinaArte = Console.ReadLine().Trim().ToLower();
                switch (disciplinaArte)
                {
                    case "a":
                        Equipaggiamento.Add("Acrobata");
                        break;
                    case "b":
                        Equipaggiamento.Add("Attore");
                        break;
                    case "c":
                        Equipaggiamento.Add("Cantore");
                        break;
                    case "d":
                        Equipaggiamento.Add("Danzatore");
                        break;
                    case "e":
                        Equipaggiamento.Add("Giocoliere");
                        break;
                    case "f":
                        Equipaggiamento.Add("Giullare");
                        break;
                    case "g":
                        Equipaggiamento.Add("Mangiatore di Fuoco");
                        break;
                    case "h":
                        Equipaggiamento.Add("Narratore");
                        break;
                    case "i":
                        Equipaggiamento.Add("Poeta");
                        break;
                    case "l":
                        Equipaggiamento.Add("Strumentista");
                        break;
                }

                Equipaggiamento.Add("Un Costume");
                Equipaggiamento.Add((GetRicchezza() + 15).ToString() + "MO");
            }

            else if (background == Background.Marinaio)
            {

                Equipaggiamento.Add("1 Galloccia da Marinaio");
                Equipaggiamento.Add("1 Corda di Seta da 15m");
                Equipaggiamento.Add("1 Porta Fortuna");
                Equipaggiamento.Add("1 Abito Comune");
                Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
            }

            else if (background == Background.Monello)
            {

                Equipaggiamento.Add("1 Coltellino");
                Equipaggiamento.Add("1 Mappa della città");
                Equipaggiamento.Add("1 Topolino addomesticato");
                Equipaggiamento.Add("1 Cionodlo ricordo dei Genitori");
                Equipaggiamento.Add("1 Abito Comune");
                Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
            }

            else if (background == Background.Nobile)
            {

                Equipaggiamento.Add("1 Abito Pregiato");
                Equipaggiamento.Add("1 Anello con Sigillo");
                Equipaggiamento.Add("1 Pergamenta con Albero Genealogico");
                Equipaggiamento.Add((GetRicchezza() + 25).ToString() + "MO");
            }


            else if (background == Background.Sapiente)
            {
                Equipaggiamento.Add("1 Calamaio e Inchiostro");
                Equipaggiamento.Add("1 Pennino");
                Equipaggiamento.Add("1 Coltellino");
                Equipaggiamento.Add("1 Una lettera con una domanda");
                Equipaggiamento.Add("1 Abito Comune");

                Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");
            }

            else if (background == Background.Soldato)
            {

                Equipaggiamento.Add("1 Mostrina con i gradi");
                Equipaggiamento.Add("1 Un Trofeo di Guerra");
                Equipaggiamento.Add("1 Set di Dadi");
                Equipaggiamento.Add("1 Mazzo di Carte");
                Equipaggiamento.Add("1 Abito Comune");

                Equipaggiamento.Add((GetRicchezza() + 10).ToString() + "MO");

            }
        }


        public int GetBonusCompetenza(int livello)
        {
            if (livello >= 1 && livello <= 4)
            {
                return 2;
            }
            else if (livello >= 5 && livello <= 8)
            {
                return 3;
            }
            else if (livello >= 9 && livello <= 12)
            {
                return 4;
            }
            else if (livello >= 13 && livello <= 16)
            {
                return 5;
            }
            else if (livello >= 17 && livello <= 20)
            {
                return 6;
            }
            else
            {

                throw new ArgumentOutOfRangeException("livello", "Il livello deve essere compreso tra 1 e 20.");
            }
        }

        public string ScegliFocusArcano()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scegli uno dei seguenti focus arcani:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(a) Bacchetta di legno (b) Bastone di legno (c) Globo di cristallo (d) Orbe di vetro (e) Pergamena semplice (f) Pugnale cerimoniale (g) Scettro d'osso (b) Verga di metallo (c) Sfera di quarzo (d) Amuleto di bronzo (e) Libro di incantesimi (f) Bacchetta d'ebano");

            string focusArcano = Console.ReadLine().Trim().ToLower();
            switch (focusArcano)
            {
                case "a":
                    return "Bacchetta di legno";
                case "b":
                    return "Bastone di legno";
                case "c":
                    return "Globo di cristallo";
                case "d":
                    return "Orbe di vetro";
                case "e":
                    return "Pergamena semplice";
                case "f":
                    return "Pugnale cerimoniale";
                case "g":
                    return "Scettro d'osso";
                case "h":
                    return "Verga di metallo";
                case "i":
                    return "Sfera di quarzo";
                case "j":
                    return "Amuleto di bronzo";
                case "k":
                    return "Libro di incantesimi";
                case "l":
                    return "Bacchetta d'ebano";
                default:
                    Console.WriteLine("Scelta non valida, seleziona di nuovo.");
                    return ScegliFocusArcano();
            }
        }


        public void ScegliStrumentoMusicale()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scegli uno degli strumenti musicali seguenti:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(a) Violino ,(b) Arpa ,(c) Chitarra ,(d) Viola ,(e) Violoncello ,(f) Flauto ,(g) Tamburo");

            string strumentoMusicale = Console.ReadLine().Trim().ToLower();
            switch (strumentoMusicale)
            {
                case "a":
                    Equipaggiamento.Add("Violino");
                    break;
                case "b":
                    Equipaggiamento.Add("Arpa");
                    break;
                case "c":
                    Equipaggiamento.Add("Chitarra");
                    break;
                case "d":
                    Equipaggiamento.Add("Viola");
                    break;
                case "e":
                    Equipaggiamento.Add("Violoncello");
                    break;
                case "f":
                    Equipaggiamento.Add("Flauto");
                    break;
                case "g":
                    Equipaggiamento.Add("Tamburo");
                    break;
            }
        }

        public void ScegliArmaSemplice()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scegli una delle seguenti armi semplici:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(a)Ascia  (b) Bastone Ferrato (c) Falcetto (d) Giavellotto (e) Lancia  (f) Martello Leggero (g) Mazza");
            Console.WriteLine("(h) Pugnale  (i) Randello  (j) Randello Pesante (k) Arco Corto  (l) Balestra Leggera  (m) Dardo  (n) Fionda");
            string armaSemplice = Console.ReadLine().Trim().ToLower();

            switch (armaSemplice)
            {
                case "a":
                    Equipaggiamento.Add("Ascia");
                    break;
                case "b":
                    Equipaggiamento.Add("Bastone Ferrato");
                    break;
                case "c":
                    Equipaggiamento.Add("Falcetto");
                    break;
                case "d":
                    Equipaggiamento.Add("Giavellotto");
                    break;
                case "e":
                    Equipaggiamento.Add("Lancia");
                    break;
                case "f":
                    Equipaggiamento.Add("Martello Leggero");
                    break;
                case "g":
                    Equipaggiamento.Add("Mazza");
                    break;
                case "h":
                    Equipaggiamento.Add("Pugnale");
                    break;
                case "i":
                    Equipaggiamento.Add("Randello");
                    break;
                case "j":
                    Equipaggiamento.Add("Randello Pesante");
                    break;
                case "k":
                    Equipaggiamento.Add("Arco Corto");
                    break;
                case "l":
                    Equipaggiamento.Add("Balestra Leggera");
                    break;
                case "m":
                    Equipaggiamento.Add("Dardo");
                    break;
                case "n":
                    Equipaggiamento.Add("Fionda");
                    break;
                default:
                    Console.WriteLine("Scelta non valida, seleziona di nuovo.");
                    ScegliArmaSemplice();
                    break;
            }
        }

        public void ScegliArmaDaGuerra()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scegli una delle seguenti armi da guerra:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(a) Spada Corta (b) Spada Lunga (c) Scimitarra (d) Spadone");
            Console.WriteLine("(e) Mazza (f) Martello (g) Martello da Guerra (h) Ascia");
            Console.WriteLine("(i) Lancia (j) Mazzafrusto (k) Bastone");

            string armaDaGuerra = Console.ReadLine().Trim().ToLower();

            switch (armaDaGuerra)
            {
                case "a":
                    Equipaggiamento.Add("Spada Corta");
                    break;
                case "b":
                    Equipaggiamento.Add("Spada Lunga");
                    break;
                case "c":
                    Equipaggiamento.Add("Scimitarra");
                    break;
                case "d":
                    Equipaggiamento.Add("Spadone");
                    break;
                case "e":
                    Equipaggiamento.Add("Mazza");
                    break;
                case "f":
                    Equipaggiamento.Add("Martello");
                    break;
                case "g":
                    Equipaggiamento.Add("Martello da Guerra");
                    break;
                case "h":
                    Equipaggiamento.Add("Ascia");
                    break;
                case "i":
                    Equipaggiamento.Add("Lancia");
                    break;
                case "j":
                    Equipaggiamento.Add("Mazzafrusto");
                    break;
                case "k":
                    Equipaggiamento.Add("Bastone");
                    break;
                default:
                    Console.WriteLine("Scelta non valida, seleziona di nuovo.");
                    ScegliArmaDaGuerra(); // Richiama la funzione se l'input non è valido
                    break;
            }
        }


        public int GetModSkill(Competenze competenza)
        {
            switch (competenze)
            {
                case Competenze.Atletica:
                    return CalcolaModificatore(Costituzione);

                case Competenze.Acrobazia:
                    return CalcolaModificatore(Destrezza);

                case Competenze.Furtività:
                    return CalcolaModificatore(Destrezza);

                case Competenze.Rapidità_di_Mano:
                    return CalcolaModificatore(Destrezza);

                case Competenze.Arcano:
                    return CalcolaModificatore(Intelligenza);

                case Competenze.Storia:
                    return CalcolaModificatore(Intelligenza);

                case Competenze.Indagare:
                    return CalcolaModificatore(Intelligenza);

                case Competenze.Natura:
                    return CalcolaModificatore(Intelligenza);

                case Competenze.Religione:
                    return CalcolaModificatore(Intelligenza);

                case Competenze.Addestrare_Animali:
                    return CalcolaModificatore(Saggezza);

                case Competenze.Intuizione:
                    return CalcolaModificatore(Saggezza);

                case Competenze.Medicina:
                    return CalcolaModificatore(Saggezza);

                case Competenze.Percezione:
                    return CalcolaModificatore(Saggezza);

                case Competenze.Sopravvivenza:
                    return CalcolaModificatore(Saggezza);

                case Competenze.Inganno:
                    return CalcolaModificatore(Carisma);

                case Competenze.Intimidire:
                    return CalcolaModificatore(Carisma);

                case Competenze.Persuasione:
                    return CalcolaModificatore(Carisma);

                case Competenze.Intrattenere:
                    return CalcolaModificatore(Carisma);

                default:
                    return 100;

            }
        }

        public int GetRicchezza()
        {
            Random random = new Random();

            switch (ClassePersonaggio)
            {
                case Classe.Barbaro:
                    return random.Next(1, 5) * 10;
                case Classe.Bardo:
                    return random.Next(1, 6) * 10;
                case Classe.Chierico:
                    return random.Next(1, 6) * 10;
                case Classe.Druido:
                    return random.Next(1, 5) * 10;
                case Classe.Guerriero:
                    return random.Next(1, 6) * 10;
                case Classe.Ladro:
                    return random.Next(1, 6) * 10;
                case Classe.Mago:
                    return random.Next(1, 6) * 10;
                case Classe.Monaco:
                    return random.Next(1, 6) * 10;
                case Classe.Paladino:
                    return random.Next(1, 6) * 10;
                case Classe.Ranger:
                    return random.Next(1, 6) * 10;
                case Classe.Stregone:
                    return random.Next(1, 5) * 10;
                case Classe.Warlock:
                    return random.Next(1, 5) * 10;
                default:
                    return 0;
            }
        }

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
            PrintLine($"Sottorazza: {SottoRazzaPersonaggio}");
            PrintLine($"Classe: {ClassePersonaggio}");
            PrintLine($"Sottoclasse: {SottoclassePersonaggio}");
            PrintLine($"Background: {BackgroundPersonaggio}");
            PrintLine($"Allineamento: {AllineamentoPersonaggio}");
            PrintLine($"Livello: {Livello}");
            PrintLine($"Punti Vita: {PuntiVita}");
            PrintLine($"Taglia: {TagliaPersonaggio()}");
            PrintLine($"Velocità: {VelocitaPersonaggio()} metri");
            PrintLine($"Scurovisione: {ScuroVisione()} metri");
            PrintLine($"Ricchezza: {GetRicchezza()}");

            // Stampa le caratteristiche con i loro modificatori
            void PrintAttribute(string name, int value)
            {
                Console.ForegroundColor = ConsoleColor.White;
                PrintLine($"{name}: {+(value)}");
                Console.ForegroundColor = ConsoleColor.Green;
                PrintLine($"{name} (Modificatore): {+((value - 10) / 2)}");
                Console.ResetColor();
            }

            PrintAttribute("Forza", Forza);
            PrintAttribute("Destrezza", Destrezza);
            PrintAttribute("Costituzione", Costituzione);
            PrintAttribute("Intelligenza", Intelligenza);
            PrintAttribute("Saggezza", Saggezza);
            PrintAttribute("Carisma", Carisma);

            // Aggiungo la stampa delle lingue conosciute dal personaggio
            Console.WriteLine($"╠{BorderLine()}╣");
            PrintLine($"Lingue conosciute da {Nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var lingua in LingueParlate)
            {
                PrintLine(lingua);
            }
            Console.ResetColor();

            // Stampa le skills con modificatori e bonus competenza
            PrintLine($"Skills di {Nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;

            int index = 1;
            foreach (var skill in Skills)
            {
                if (Enum.TryParse(skill, out Competenze competenza))
                {
                    int modificatore = GetModSkill(competenza);
                    int bonusCompetenza = GetBonusCompetenza(Livello);
                    int totale = modificatore + bonusCompetenza;

                    // Stampa la competenza con il modificatore e il totale
                    PrintLine($"{index}. {skill}: {modificatore}, Bonus Comp. +{bonusCompetenza}, Tot: {totale:+#;-#;0}");
                }
                else
                {
                    // Se non è possibile fare il parse, stampa solo il nome della skill
                    PrintLine($"{index}. {skill}");
                }
                index++;
            }

            Console.ResetColor();

            // Allinea automaticamente la riga della ricchezza
            string ricchezza = $"{GetRicchezza()} monete d'oro";
            PrintLine($"Ricchezza di {Nome}:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintLine(ricchezza.PadRight(borderWidth - 2));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.ResetColor();
            PrintLine($"Equipaggiamento di {Nome}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int indexEquipaggiamento = 1;
            foreach (var armaturaString in Equipaggiamento)
            {
                if (Enum.TryParse(armaturaString, out Equipaggiamento equipaggiamento))
                {
                    // Se il parse è riuscito, stampa la competenza con il modificatore e il totale
                    PrintLine($"{indexEquipaggiamento}. {equipaggiamento}");
                }
                else
                {
                    // Se non è possibile fare il parse, stampa solo il nome della skill
                    PrintLine($"{indexEquipaggiamento}. {armaturaString}");
                }
                indexEquipaggiamento++;

                Console.ResetColor();



               
            }
 Console.WriteLine($"╚{BorderLine()}╝");
        }
    }
}