using MTGCollection.DataSource;
using MTGCollection.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MTGCollection.Persistent
{
    public class cardDAL : IDisposable
    {
        public EntDbConnection con;

        public cardDAL()
        {
            con = new EntDbConnection();
        }


        #region SETs
        public void addCard(Card c)
        {
            con.C.Add(c);
            con.SaveChanges();
        }

        #endregion

        #region GETs
        public Card getCardByID(int id)
        {
            IQueryable<Card> c = con.C.Where(x => x.Id == id);

            if (c.Count() > 0)
            {
                return c.First();
            }
            else
            {
                return null;
            }


        }

        public Card getCardByName(string nome)
        {
            IQueryable<Card> c = con.C.Where(x => x.Nome == nome);

            if (c.Count() > 0)
            {
                return c.First();
            }
            else
            {
                return null;
            }



        }

        public Card getCardByColor(string cor)
        {
            IQueryable<Card> c = con.C.Where(x => x.Cor == cor);

            if (c.Count() > 0)
            {
                return c.First();
            }
            else
            {
                return null;
            }

        }

        public Card getCardByType(string tipo)
        {
            IQueryable<Card> c = con.C.Where(x => x.Tipo == tipo);

            if (c.Count() > 0)
            {
                return c.First();
            }
            else
            {
                return null;
            }

        }

        public List<Card> getAllCards()
        {
            List<Card> list = new List<Card>();

            foreach (Card c in con.C.ToList())
            {
                list.Add(c);
            }

            return list;
        }

        public List<Card> getAllCardsFiltered(int id, string name, string color, string type)
        {
            List<Card> list = new List<Card>();
            list.AddRange(con.C.ToList().Where(i => i.Id == id));
            list.AddRange(con.C.ToList().Where(n => n.Nome == name));
            list.AddRange(con.C.ToList().Where(c => c.Cor == color));
            list.AddRange(con.C.ToList().Where(t => t.Tipo == type));



            return list;
        }
        #endregion


        #region deletes

        public void removeAmountFromID(int id, int amount)
        {
            Card card = con.C.Single(x => x.Id.Equals(id));


            if (card.Quantidade - amount <= 0)
            {
                con.C.Remove(card);
            }
            else
            {
                card.Quantidade -= amount;
            }



            con.SaveChanges();


        }


        #endregion


        public void Dispose()
        {
            GC.SuppressFinalize(this);
            con.Dispose();
        }
    }
}
