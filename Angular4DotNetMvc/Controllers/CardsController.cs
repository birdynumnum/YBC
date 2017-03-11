using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Web.Mvc;
using ServiceLayer;
using Domain.Card;
using Angular4DotNetMvc.ExtensionMethods;
using DataLayer.Repo;
using ServiceLayer.Null;
using Domain.ValueObjects;
using Domain;
using Angular4DotNetMvc.Models.ViewModels;

namespace Angular4DotNetMvc.Controllers
{
    public class CardsController : JsonController
    {
        private readonly IBusinessCardService cardservice;

        public CardsController(IBusinessCardService _cardservice)
        {
            cardservice = _cardservice;
        }

        public ActionResult Index()
        {
            return Json(cardservice.GetAll(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(CardVM cardvm)
        {
            Result<EMail> mailaddress = EMail.Create(cardvm.Email);
            Card newcard = new Card(cardvm.Id, cardvm.Name, cardvm.Company, cardvm.Telephone, cardvm.Notes, mailaddress.Value);

            newcard.ConvertVmToModel(cardvm);
            cardservice.CreateCard(newcard);
            cardservice.Save();
            return View();
        }

        public ActionResult GetCard(int Id)
        {
            Maybe<Card> foundcard = cardservice.GetCardById(Id);
            if (foundcard.HasValue)
            {
                return Json(foundcard, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Delete(int id)
        {
            Maybe<Card> foundcard = cardservice.GetCardById(id);
            if (foundcard.HasNoValue)
            {
                return HttpNotFound();
            }
            else
            {
                cardservice.DeleteCard(foundcard.Value.Id);
                cardservice.Save();
            }
            return RedirectToAction("Index", "Cards");
        }

        [HttpGet]
        public ActionResult Search(string key)
        {
            return Json(cardservice.Search(key), JsonRequestBehavior.AllowGet);
        }
    }
}
