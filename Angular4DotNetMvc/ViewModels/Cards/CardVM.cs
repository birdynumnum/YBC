using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Infrastructure;
using Infrastructure.Mapping;
using Domain.Card;
using Domain.ValueObjects;

namespace Angular4DotNetMvc.Models.ViewModels
{
    public class CardVM : IMapFrom<Card>
    {
        [HiddenInput(DisplayValue=false)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Company { get; set; }

        public string Email { get; set; }
 
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Telephone { get; set; }
        
        public string Notes { get; set; }
    }
}