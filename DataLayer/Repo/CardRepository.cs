using DataLayer.Context;
using Domain.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    public class CardRepository :  Repository<Card>, ICardRepository
    {
        public CardRepository(IDbFactory dbfactory) : base(dbfactory)
        {

        }
    }
}
