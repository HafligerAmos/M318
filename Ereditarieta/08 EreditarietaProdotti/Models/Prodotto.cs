using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EreditarietaProdotti.Models
{
    internal class Prodotto
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        private int _codice;

        public int Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        private string _descrizione;

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        private float _prezzo;

        public float Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }

        #endregion

        #region =03=== costruttori =======================ctor==

        public Prodotto(int codice, string descrizione, float prezzo)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        public float ApplicaSconto()
        {
            return Prezzo / 100 * 95;
        }

        public override string ToString()
        {
            return String.Format("{0, -10} {1, -10} {2, -10}",Codice,Descrizione,Prezzo);
        }

        #endregion

    }
}
