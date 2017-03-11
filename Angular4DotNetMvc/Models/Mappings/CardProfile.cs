using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Domain.Card;
using Angular4DotNetMvc.Models.ViewModels;

namespace Angular4DotNetMvc.Models.Mappings
{
    public class CardProfile  : Profile
    {
        protected override void Configure()
        {
 	         base.CreateMap<Card, CardVM>();
        }
    }
}