﻿using AutoMapper;
using DemoDotNet5.Models;
using DemoDotNet5.ViewModel;
using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OA.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNet5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly ILog log = LogManager.GetLogger(typeof(HomeController));
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, IProductService productService, IMapper mapper,ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string search, int currentPage, int pageSize)
        {
            // Danh sách sản phẩm mới
            var dataNewProducs = await _productService.NewProducts(search, currentPage, pageSize);
            var newProducts = dataNewProducs.Items;
            var newProductsViewModel = _mapper.Map<List<ProductViewModel>>(newProducts);
            ViewBag.newProductsViewModel = newProductsViewModel;

            // Danh sách sản phẩm nổi bật
            var dataFeaturedProducts = await _productService.FeaturedProducts(search,currentPage,pageSize);
            var featuredProducts = dataFeaturedProducts.Items;
            var featuredProductsViewModel = _mapper.Map<List<ProductViewModel>>(featuredProducts);
            ViewBag.featuredProductsViewModel = featuredProductsViewModel;

            // Danh sách danh mục 
            var categories = _categoryService.GetList();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.categoriesViewModel = categoriesViewModel;
           

            // Test log4net
            // Nếu level = INFO thì chỉ log được từ INFO trở đi cụ thể dưới đây
            // là WARN và INFO.
            // log.Warn("Warn");
            // log.Debug("Debug");
            // log.Info("Info");

            // Test serilog
            // _logger.LogError("Error");
            return View();
        }

        // Chi tiết sản phẩm
        public async Task<IActionResult> DetailProduct(int id, int currentPage, int pageSize)
        {
            // Chi tiết sản phẩm
            var detailProduct = await _productService.GetId(id);
            var detailProductViewModel = _mapper.Map<ProductViewModel>(detailProduct);
            ViewBag.detailProductViewModel = detailProductViewModel;

            // Sản phẩm cùng loại
            var dataRelatedProducts = await _productService.RelatedProducts(detailProduct.CategoryId, currentPage,pageSize);
            var relatedProducts = dataRelatedProducts.Items;
            var relatedProductsViewModel = _mapper.Map<List<ProductViewModel>>(relatedProducts);
            ViewBag.relatedProductsViewModel = relatedProductsViewModel;
            return View();
        }


        // Sản phẩm liên quan
        public async Task<IActionResult> RelatedProducts(int id, int currentPage, int pageSize)
        {
            var categories = _categoryService.GetList();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.categoriesViewModel = categoriesViewModel;

            var dataRelatedProducts = await _productService.RelatedProducts(id,currentPage,pageSize);
            var relatedProducts = dataRelatedProducts.Items;
            var relatedProductsViewModel = _mapper.Map<List<ProductViewModel>>(relatedProducts);
            ViewBag.relatedProductsViewModel = relatedProductsViewModel;
            return View();
        }


        // Trang sản phẩm
        public async Task<IActionResult> ShopProducts(string search, int currentPage, int pageSize)
        {
            var categories = _categoryService.GetList();
            var categoriesViewModel = _mapper.Map<List<CategoryViewModel>>(categories);
            ViewBag.categoriesViewModel = categoriesViewModel;

            var dataShopProducts = await _productService.ShopProducts(search, currentPage, pageSize);
            var shopProducts = dataShopProducts.Items;
            var shopProductsViewModel = _mapper.Map<List<ProductViewModel>>(shopProducts);
            ViewBag.shopProductsViewModel = shopProductsViewModel;
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
