using Domain;
using Domain.Card;
using Domain.ValueObjects;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataLayer.Context
{
    public class CardSeed : DropCreateDatabaseAlways<CardEntities>
    {
        protected override void Seed(CardEntities context)
        {
            foreach (Card c in GetCards())
            {
                context.Cards.Add(c);
                context.Entry(c).State = EntityState.Added;
                context.Commit();
            }
        }

        private static List<Card> GetCards()
        {

            Result<EMail> MTResult = EMail.Create("ducati@quicknet.nl");
            EMail dummymail = MTResult.Value as EMail;

            return new List<Card> {
                new Card { Id = 1, Name = "Dummy", Company = "Test", Notes = "Test Notes Dummy", Telephone = "123456789", EMail = dummymail },
                new Card { Id = 2, Name = "Hollywood", Company = "Test", Telephone = "123456789", Notes = "This is a test Hollywood Entity Note", EMail = dummymail },
                new Card {Id = 3, Name = "Bugger", Company="Test", Telephone="123456789", Notes="This is a test Bugger Entity Note", EMail= dummymail},
                new Card {Id = 4, Name = "Yueming", Company="Test",Telephone="123456789", Notes="This is a test Droppie Entity Note", EMail= dummymail},
                new Card {Id = 5, Name = "Arrie", Company="Test", Telephone="123456789", Notes="This is a test Arnold Entity Note", EMail= dummymail}
            };
        }
    }
}
