using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DrinkingOrder.BK.Sit.Models.Entities
{
	public class StoreEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string OpeningHours { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
		public string Moblie { get; set; }
		public string Payway { get; set; }
		public string PromoteImage { get; set; }
	}
}