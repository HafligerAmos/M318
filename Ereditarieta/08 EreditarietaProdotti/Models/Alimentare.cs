using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EreditarietaProdotti.Models
{
    internal class Alimentare : Prodotto
    {
        #region =01=== costanti & statici ======================
        #endregion

        #region =02=== membri & proprietà ============propfull==
        private DateTime _data;

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        #endregion

        #region =03=== costruttori =======================ctor==
        public Alimentare(DateTime data,int codice, string descrizione, int prezzo) :base(codice,descrizione,prezzo)
        {
            Data = data;
        }
        #endregion

        #region =04=== metodi private e aiuto ==================
        #endregion

        #region =05=== metodi public ===========================
        public float applicaSconto()
        {
            if(Data.Day < 10) {
                Prezzo = Prezzo / 100 * 80;
            }
            return Prezzo;
        }
        #endregion

    }
}
