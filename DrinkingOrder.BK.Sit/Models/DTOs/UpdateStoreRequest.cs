using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinkingOrder.BK.Sit.Models.DTOs
{
	public class UpdateStoreRequest
	{//店家更改資料
		public string Name { get; set; }
		public string OpeningHours { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
		public string Moblie { get; set; }
		public string Payway { get; set; }
		public string PromoteImage { get; set; }
	}
}