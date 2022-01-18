using DrinkingOrder.BK.Sit.Models.Core.Interface;
using DrinkingOrder.BK.Sit.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinkingOrder.BK.Sit.Models.Core.Service
{
	public class StoreService
	{
		private IStoreRepository repository;
		public StoreService(IStoreRepository _repository)
		{
			repository = _repository;
		}

		public void UpdateStoreInfo(UpdateStoreRequest source)
		{

		}
	}
}