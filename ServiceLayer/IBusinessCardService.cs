using Domain.Card;
using Domain.ValueObjects;
using ServiceLayer.Null;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IBusinessCardService
    {
        IEnumerable<Card> GetAll();
        IEnumerable<Card> GetCards(string name);
        Maybe<Card> GetCardById(int id);
        void CreateCard(Card card);
        void DeleteCard(int id);
        IEnumerable<Card> Search(string searchkey);
        void Save();
    }
}
