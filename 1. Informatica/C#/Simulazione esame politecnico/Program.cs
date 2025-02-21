using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var giocatori = LeggiGiocatori("sportivi.csv");
        var segniZodiacali = LeggiSegniZodiacali("zodiaco.csv");
        var goalPerSegno = CalcolaGoalPerSegno(giocatori, segniZodiacali);
        StampaIstogramma(goalPerSegno);
    }

    static List<(string nome, int goal, DateTime dataNascita)> LeggiGiocatori(string filePath)
    {
        var lista = new List<(string, int, DateTime)>();
        foreach (var linea in File.ReadLines(filePath))
        {
            var dati = linea.Split(',');
            string nome = dati[0];
            int goal = int.Parse(dati[1]);
            DateTime dataNascita = DateTime.ParseExact(dati[3], "dd/MM/yyyy", null);
            lista.Add((nome, goal, dataNascita));
        }
        return lista;
    }

    static Dictionary<string, (DateTime inizio, DateTime fine)> LeggiSegniZodiacali(string filePath)
    {
        var dizionario = new Dictionary<string, (DateTime, DateTime)>();
        foreach (var linea in File.ReadLines(filePath))
        {
            var dati = linea.Split(',');
            string segno = dati[0];
            DateTime inizio = DateTime.ParseExact(dati[1] + "/2024", "dd/MM/yyyy", null);
            DateTime fine = DateTime.ParseExact(dati[2] + "/2024", "dd/MM/yyyy", null);
            dizionario[segno] = (inizio, fine);
        }
        return dizionario;
    }

    static Dictionary<string, int> CalcolaGoalPerSegno(List<(string nome, int goal, DateTime dataNascita)> giocatori,
                                                        Dictionary<string, (DateTime inizio, DateTime fine)> segni)
    {
        var goalPerSegno = new Dictionary<string, int>();
        foreach (var (nome, goal, dataNascita) in giocatori)
        {
            foreach (var (segno, (inizio, fine)) in segni)
            {
                DateTime nascita2024 = new DateTime(2024, dataNascita.Month, dataNascita.Day);
                if (nascita2024 >= inizio && nascita2024 <= fine)
                {
                    if (!goalPerSegno.ContainsKey(segno))
                        goalPerSegno[segno] = 0;
                    goalPerSegno[segno] += goal;
                    break;
                }
            }
        }
        return goalPerSegno;
    }

    static void StampaIstogramma(Dictionary<string, int> goalPerSegno)
    {
        int maxGoal = goalPerSegno.Values.Max();
        const int maxBarLength = 50;

        var ordinato = goalPerSegno.OrderByDescending(kv => kv.Value);
        foreach (var (segno, goal) in ordinato)
        {
            int barLength = (goal * maxBarLength) / maxGoal;
            Console.WriteLine($"{segno,-10} ({goal}) {new string('*', barLength)}");
        }
    }
}