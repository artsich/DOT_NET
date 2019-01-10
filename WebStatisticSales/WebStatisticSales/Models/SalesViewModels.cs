﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStatisticSales.Models
{
	public class SaleFilterView
	{
		[Display(Name = "Имя покупателя")]
		public string ClientFilter { get; set; }

		[Display(Name = "Имя продавца")]
		public string SellerFilter { get; set; }

		[Display(Name = "Название продукта")]
		public string ProductFilter { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Недопустимая цена")]
		public int? CostFilter { get; set; }
	}

	public class SaleView
	{
		[HiddenInput(DisplayValue = false)]
		public int Id { get; set; }

		[Display(Name = "Продавец")]
		public string Seller { get; set; }

		[Display(Name = "Клиeнт")]
		public string Client { get; set; }

		[Display(Name = "Название продукта")]
		public string Product { get; set; }

		[Display(Name = "Стоимость")]
		public int Cost { get; set; }

		[Display(Name = "Дата продажи")]
		[DataType(DataType.Date)]
		//[DisplayFormat(DataFormatString = "{mm/dd/yyyy}")]
		public DateTime Date { get; set; }
	}

	public class SaleCreateView
	{
		[Display(Name = "Продавец")]
		[Required(ErrorMessage = "Выберите продовца")]
		public int SellerId { get; set; }

		[Display(Name = "Клиeнт")]
		[Required(ErrorMessage = "Выберите покупателя")]
		public int ClientId { get; set; }

		[Required(ErrorMessage = "Продукт")]
		[Display(Name = "Название продукта")]
		public int ProductId { get; set; }

		[Required]
		[Display(Name = "Стоимость")]
		[Range(1, int.MaxValue, ErrorMessage = "Недопустимая цена")]
		public int Cost { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "Дата продажи")]
		public DateTime Date { get; set; }
	}

	public class SaleEditView
	{
		[HiddenInput(DisplayValue = false)]
		public int Id { get; set; }

		[Display(Name = "Продавец")]
		[Required(ErrorMessage = "Выберите продовца")]
		public int SellerId { get; set; }

		[Display(Name = "Клиeнт")]
		[Required(ErrorMessage = "Выберите покупателя")]
		public int ClientId { get; set; }

		[Required(ErrorMessage = "Продукт")]
		[Display(Name = "Название продукта")]
		public int ProductId { get; set; }

		[Required]
		[Display(Name = "Стоимость")]
		[Range(1, int.MaxValue, ErrorMessage = "Недопустимая цена")]
		public int Cost { get; set; }

		[Required]
		[DataType(DataType.Date)]
		[Display(Name = "Дата продажи")]
		public DateTime Date { get; set; }
	}
}