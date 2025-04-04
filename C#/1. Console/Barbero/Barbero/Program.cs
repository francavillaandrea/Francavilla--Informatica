namespace Barbero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[15];
            int[] va = new int[15];
            int[] vb = new int[15];
            int[] vD = new int[5];
            int[] vO = { 3, 8, 8, 25, 69 };
            //ClsAlgoritmi.caricaVettori(vD);
            //ClsAlgoritmi.stampaVettore(vD);
            //ClsAlgoritmi.ricercaSequenziale1(v);
            //ClsAlgoritmi.ricercaSequenziale2(v);
            //ClsAlgoritmi.stampaVettore(vO);
            //ClsAlgoritmi.ricercaSequenziale3(vO);
            //ClsAlgoritmi.ricercaSequenziale4(vO);
            //ClsAlgoritmi.RicBin(vD);
            //ClsAlgoritmi.caricaVettori(v);
            //ClsAlgoritmi.stampaVettore(v);
            //ClsAlgoritmi.selectionSort(v);
            //ClsAlgoritmi.stampaVettore(v);
            //ClsAlgoritmi.stampaVettore(v);
            //ClsAlgoritmi.bobuSort(v);
            //ClsAlgoritmi.stampaVettore(v);
            //ClsAlgoritmi.caricaVettori(va);
            //ClsAlgoritmi.caricaVettori(vb);
            //ClsAlgoritmi.stampaVettore(va);
            //ClsAlgoritmi.stampaVettore(vb);
            //ClsAlgoritmi.mergeNoTappo(va, vb);
            ClsAlgoritmi.caricaVettori(va);
            ClsAlgoritmi.caricaVettori(vb);
            ClsAlgoritmi.stampaVettore(va);
            ClsAlgoritmi.stampaVettore(vb);
            ClsAlgoritmi.mergeTappo(va, vb);

        }
    }
}
