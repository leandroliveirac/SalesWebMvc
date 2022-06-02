﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var sellers = _sellerService.FindAll();
            return View(sellers);
        }
    }
}
