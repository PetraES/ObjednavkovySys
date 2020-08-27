using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjednavkovySys
{
    public partial class Form1 : Form
    {
        List<Objednavka> SeznamObjednavek;
        List<ObjednavkaPolozka> SeznamPolozek;

        public Form1()
        {
            InitializeComponent();
            SeznamObjednavek = new List<Objednavka>();
            SeznamPolozek = new List<ObjednavkaPolozka>();
        }

        public void NactiCSV(string cestaKSouboru, string typSouboru)
        {
            StreamReader s = new StreamReader(cestaKSouboru);
            int pocetRadku = 0;
            while (!s.EndOfStream)
            {
                string radek = s.ReadLine();
                if (pocetRadku == 0)
                {
                    pocetRadku++;
                }
                else
                {
                    string[] polozkyRadku = radek.Split(';');
                    if (typSouboru == "objednavka")
                    {
                        Objednavka o = new Objednavka();
                        o.Cislo = int.Parse(polozkyRadku[0]);
                        o.DatumObjednavky = DateTime.Parse(polozkyRadku[1], CultureInfo.GetCultureInfo("cs"));
                        o.Odberatel = (string)(polozkyRadku[2]);
                        SeznamObjednavek.Add(o);

                    }
                    else if (typSouboru == "ObjednavkaPolozka")
                    {
                        ObjednavkaPolozka jednaPolozkaObjednavky = new ObjednavkaPolozka();
                        jednaPolozkaObjednavky.CisloObjednavky = int.Parse(polozkyRadku[0]);
                        jednaPolozkaObjednavky.Nazev = (string)(polozkyRadku[1]);
                        jednaPolozkaObjednavky.JednotkovaCena = int.Parse(polozkyRadku[2]);
                        jednaPolozkaObjednavky.Mnozstvi = int.Parse(polozkyRadku[3]);
                        SeznamPolozek.Add(jednaPolozkaObjednavky);
                    }
                    else throw new Exception("Nepodarilo se nacist CSV.");
                    pocetRadku++;
                }
            }
        }

        /// <summary>
        /// zobrazi seznam objednavek do listView
        /// </summary>
        public void NaplListViewObjednavky() 
        {
            if (SeznamObjednavek != null)
            {
                foreach (var item in SeznamObjednavek)
                {
                    string[] polozkyListView = new string[] {
                        item.Cislo.ToString(),
                        item.DatumObjednavky.ToShortDateString(),
                        item.Odberatel };
                    var radekZaznamu = new ListViewItem(polozkyListView);
                    listView1_SeznamObjednavek.Items.Add(radekZaznamu);
                }
            }

            else
            {
                MessageBox.Show("seznam objdenavek je prazdny");
            }
        }
      
        public void ZobrazSeznamPolozek(int cisoVybraneObjednavky)
        {
            this.listView2_SeznamPolozekObjednavky.Items.Clear();
            IEnumerable<ObjednavkaPolozka> vybranaPolozkaQuery =
                from polozka in SeznamPolozek
                where polozka.CisloObjednavky == cisoVybraneObjednavky              
                orderby polozka.Nazev.ToLower()
                select polozka;                            

            foreach (ObjednavkaPolozka item in vybranaPolozkaQuery)
            {
                string[] polozkyListView = new string[] {
                    item.CisloObjednavky.ToString(),
                    item.Nazev,
                    item.JednotkovaCena.ToString(),
                    item.Mnozstvi.ToString() };

               var radekZaznamu = new ListViewItem(polozkyListView);
                listView2_SeznamPolozekObjednavky.Items.Add(radekZaznamu);
            }
        }

        public bool JePrvocislo(int cislo)
        {
            if (cislo <= 1)
            {
                return false;
            }
            else if (cislo == 2)
            {
                return true;
            }
            else if (cislo % 2 == 0)
            {
                return false;
            }

            else
            {
                int sqrt = (int)Math.Sqrt(cislo);
                for (int i = 3; i <= sqrt; i += 2)
                {
                    if (cislo % i == 0)
                        return false;
                }
                return true;
            }          
        }

        public List<int> NaplPrvocisla(int dolni, int horni)
        {
            List<int> prvocisla = new List<int>();
            Parallel.For(dolni, horni, (x) =>
             {
                 if (JePrvocislo(x))
                 {
                     lock (((ICollection)prvocisla).SyncRoot)
                     {
                         prvocisla.Add(x);
                     }
                 }
             });

            return prvocisla;
        }

        private void listView1_SeznamObjednavek_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListView.SelectedListViewItemCollection vybranaObjednavka = listView1_SeznamObjednavek.SelectedItems;
            if (vybranaObjednavka.Count > 0)
            {                
                ZobrazSeznamPolozek(int.Parse(vybranaObjednavka[0].SubItems[0].Text));
            }
            
        }

        private void button1_Nacist_Click(object sender, EventArgs e)
        {
            // this.listView1_SeznamObjednavek.Items.Clear();
            string objednavkaPath = Properties.Settings.Default.ObjednvkaFile;
            string polozkyObjednavky = Properties.Settings.Default.PolozkyObjednavky;

            //MessageBox.Show(objednavkaPath);
            //MessageBox.Show(objednavkaPath);

            Task[] tasks =
            {
                // spusti prvni vlakno
                Task.Run( () => NactiCSV(objednavkaPath, "objednavka") ),
                // spusti dalsi vlakno
                Task.Run( () => NactiCSV(polozkyObjednavky, "ObjednavkaPolozka") )
            };

            tasks[0].Wait();
            tasks[1].Wait();
            NaplListViewObjednavky();
        }

        private void button2_Mesice_Click(object sender, EventArgs e)
        {
            this.listBox1_Vysledky.Items.Clear();
            if (SeznamObjednavek != null)
            {
                // IGrouping chce dva parametry
                // TKey je hodnota klice - datovy typ toho, podle ceho to groupuju
                // TElement datovz typ toho co groupuju
                IEnumerable<IGrouping<int,Objednavka>> sekvenceMesiceQuery =
                    from objednavka in SeznamObjednavek
                    group objednavka by objednavka.DatumObjednavky.Month into mesic
                    orderby mesic.Key select mesic;

                foreach (IGrouping<int,Objednavka> skupinaObjednavek in sekvenceMesiceQuery)
                {
                    listBox1_Vysledky.Items.Add(string.Format("{0}", skupinaObjednavek.Key));
                    foreach (Objednavka objednavkyVMesici in skupinaObjednavek)
                    {
                        listBox1_Vysledky.Items.Add(string.Format("\n{0}, \t{1}, \t{2}",
                            objednavkyVMesici.Cislo,
                            objednavkyVMesici.DatumObjednavky.ToShortDateString(),
                            objednavkyVMesici.Odberatel));
                    }
                }          
            }

            else
            {
                MessageBox.Show("Seznam objednavek je prazdny.");
            }
        }

        private void button3_Ceny_Click(object sender, EventArgs e)
        {
            this.listBox1_Vysledky.Items.Clear();

            var sekvenceMesic = from objednavka in SeznamObjednavek.AsParallel()
                                let sum = (from su in SeznamPolozek where su.CisloObjednavky == objednavka.Cislo select su.JednotkovaCena * su.Mnozstvi).Sum()
                                where sum >= 4000
                                // vytvareni anonymniho typu který má properties Objednavka a Suma
                                select new { Objednavka = objednavka, Suma = sum };

            foreach (var anonymniTyp in sekvenceMesic)
            {
                listBox1_Vysledky.Items.Add(string.Format("{0}, \t{1}, \t{2}, \t{3}",
                    anonymniTyp.Objednavka.Cislo,
                    anonymniTyp.Objednavka.DatumObjednavky,
                    anonymniTyp.Objednavka.Odberatel,
                    anonymniTyp.Suma.ToString()));
            }
        }

        private void button4_prvocisla_Click(object sender, EventArgs e)
        {
            this.listBox1_Vysledky.Items.Clear();
            List<int> listPrvocisel = NaplPrvocisla(2000,5000);

            int pocetCiselVListu = 0;
            foreach (int prvocislo in listPrvocisel)            
            {
                if (pocetCiselVListu == 10)
                {
                    break;
                }

                listBox1_Vysledky.Items.Add(prvocislo);
                pocetCiselVListu++;
            }                  
        }

        private void button5_exportovat_Click(object sender, EventArgs e)
        {

        }
    }
}
