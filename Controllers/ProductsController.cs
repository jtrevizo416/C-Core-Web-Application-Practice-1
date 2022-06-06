﻿using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_App_Practice_1_Refresher_5_19_2022.Models;
using Web_App_Practice_1_Refresher_5_19_2022.Services;

namespace Web_App_Practice_1_Refresher_5_19_2022.Controllers
{
    public class ProductsController : Controller
    {
       public IActionResult Index()
        {
            ProductsDAO products = new ProductsDAO();
            return View(products.GetAllProducts());
        }

        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productList = products.SearchProducts(searchTerm);
            return View("index", productList);
        }

        public IActionResult ShowDetails(int id)
        {

            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        }

        public IActionResult Edit(int id)
        {

            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("ShowEdit",foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {

            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult Delete(int id)
        {

            ProductsDAO products = new ProductsDAO();
            ProductModel product = products.GetProductById(id);
            products.Delete(product);
            return View("Index", products.GetAllProducts());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ProcessCreate(ProductModel product)
        {

            ProductsDAO products = new ProductsDAO();
            products.Insert(product);
            return View("Index",products.GetAllProducts());
        }




        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.SecretNum = secretNumber;
            return View();
        }
    }
}
