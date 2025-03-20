using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateca
{
    public struct Socio
    {
        public string codSocio;
        public string cognome;
        public string nome;
        public string email;
        public string telefono;
    }
   
    internal class clsSoci
    {
        public static Socio[] soci = new Socio[50];
        public static string[] datiSoci = new string[]
        {
            "s1,Rossi,Mario,mario@rossi.it,3246785431",
            "s2,Brambilla,Lorenzo,lorenzo@brambilla.it,3298765430",
            "s3,Bianchi,Roberta,roberta@bianchi.it,3476722198",
            "s4,Ferrero,Luigi,luigi@ferrero.it,3337651239",
            "s5,Montessori,Maria,maria@montessori.it,3270985632",
            "s6,Abate,Anna,anna@abate.it,3984560021",
            "s7,Pautasso,Giuseppe,giuseppe@pautasso.it,3126754492",
        };

        public static int nSoci;

        internal static void caricaSoci(object dgvSoci)
        {
            caricaTabellaSoci();
            visualizzaTabellaSoci(dgvSoci);
        }

        private static void visualizzaTabellaSoci(object dgvSoci)
        {
            throw new NotImplementedException();
        }

        private static void caricaTabellaSoci()
        {
            for (int i = 0; i < datiSoci.Length; i++)
            {
                string[] dati = datiSoci[i].Split(',');
                soci[i].codSocio = dati[0];
                soci[i].cognome = dati[1];
                soci[i].nome = dati[2];
                soci[i].email= dati[3];
                soci[i].telefono= dati[4];
            }
        }
    }
}
