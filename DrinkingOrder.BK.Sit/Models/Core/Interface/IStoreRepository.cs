using DrinkingOrder.BK.Sit.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinkingOrder.BK.Sit.Models.Core.Interface
{
	public interface IStoreRepository
	{
		bool IsExist(string account);//判斷資料庫中是否有這筆帳號資訊

		void Create();

		StoreEntity Load(int storeId);
		StoreEntity Load(string account);

		void Update(StoreEntity store);

		void UpdatePassword(StoreEntity store);


	}
}