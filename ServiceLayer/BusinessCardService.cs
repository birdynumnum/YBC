using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Card;
using DataLayer.Repo;
using ServiceLayer.Null;
using Domain.ValueObjects;

namespace ServiceLayer
{
    public class BusinessCardService : IBusinessCardService
    {
        private readonly ICardRepository cardRepo;
        private readonly IUnitOfWork unitofwork;

        public BusinessCardService(ICardRepository _cardrepo, IUnitOfWork _unitofwork)
        {
            cardRepo = _cardrepo;
            unitofwork = _unitofwork;
        }

        public IEnumerable<Card> GetAll()
        {
            return cardRepo.GetAll();
        }

        public IEnumerable<Card> GetCards(string name)
        {
            var cards = cardRepo.GetAll().Where(c => c.Name == name);
            return cards;
        }

        public Maybe<Card> GetCardById(int id)
        {
            Maybe<Card> foundcard = cardRepo.GetById(id);
            return foundcard.Value;
        }

        public void CreateCard(Card card)
        {
            cardRepo.Insert(card);
        }

        public void DeleteCard(int id)
        {
            Maybe<Card> foundcard = GetCardById(id);
            cardRepo.Delete(foundcard.Value);
        }

        public IEnumerable<Card> Search(string key)
        {
            IEnumerable<Card> foundcards = new List<Card>();
            string searchkey = key.Trim().ToLower();

            foundcards = cardRepo.GetAll()
                     .OrderBy(c => c.Id)
                     .Where(c => c.Name.ToLower().Contains(searchkey) ||
                     (c.Company.ToLower().Contains(searchkey) ||
                     c.EMail.Value.ToLower().Contains(searchkey))).ToList();

            if (foundcards.Count() != 0) return foundcards;

            else return foundcards.ToList();
        }

        public void Save()
        {
            unitofwork.Commit();
        }

    }
}
