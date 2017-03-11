using Angular4DotNetMvc.Models.ViewModels;
using Domain.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular4DotNetMvc.ExtensionMethods
{
    public static class CardVMExtension
    {
        public static Card ConvertVmToModel(this Card card, CardVM cardvm)
        {
            card.Name = cardvm.Name;
            card.Company = cardvm.Company;
            //card.EMails = cardvm.Email;
            card.Telephone = cardvm.Telephone;
            card.Notes = cardvm.Notes; 
            
            return card;
        }
    }
}