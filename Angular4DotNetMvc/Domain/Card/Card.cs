using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Card
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Telephone { get; set; }
        public string Notes { get; set; }
        public EMail EMail { get; set; }

        public Card()
        {
        }

        public Card(int id, string name, string company, string telephone, string notes, EMail email)
        {
            Id = id;
            Name = name;
            Company = company;
            Telephone = telephone;
            Notes = notes;
            EMail = email;
        }
    }
}
