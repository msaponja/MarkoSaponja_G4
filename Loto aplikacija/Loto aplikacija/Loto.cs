using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Loto_aplikacija
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        public Loto()
        {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="korisnickeVrijednosti"></param>
        /// <returns></returns>
        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti) 
        {

            bool ispravni = false;
            UplaceniBrojevi.Clear();
            foreach (string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(v, out broj)==true)
                {
                    if (broj >= 1 && broj<=39)
                    {
                        if (UplaceniBrojevi.Contains(broj)==false)
                        {
                            UplaceniBrojevi.Add(broj);
                        }
                    }
                }
            }
            if (UplaceniBrojevi.Count == 7)
            {
                ispravni = true;
            }
            
            return ispravni;

        }
        public void IzbaciDobitne() 
        {
            DobitniBrojevi.Clear();
            Random r = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = r.Next(1, 39);
                if (DobitniBrojevi.Contains(broj)==false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }
        
        
        }
        public int izracunPogodaka(FrmLoto forma) 
        {
            int brojPogodaka = 0;
            foreach (int a in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(a))
                {
                    brojPogodaka++;
                    
                    
                }
            }
            return brojPogodaka;
        
        }
    }
}
