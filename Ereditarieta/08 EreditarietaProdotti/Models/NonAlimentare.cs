using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EreditarietaProdotti.Models
{
    internal class NonAlimentare : Prodotto
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        private string _materiale;

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        #endregion

        #region =03=== costruttori =======================ctor==
        public NonAlimentare(string materiale, int codice, string descrizione, int prezzo) : base(codice, descrizione, prezzo)
        {
            Materiale = materiale;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        public float applicaSconto()
        {
            if (Materiale.Equals("carta")||Materiale.Equals("vetro")||Materiale.Equals("plastica"))
            {
                Prezzo = Prezzo / 100 * 90;
            }
            return Prezzo;
        }
        #endregion
    }
}
