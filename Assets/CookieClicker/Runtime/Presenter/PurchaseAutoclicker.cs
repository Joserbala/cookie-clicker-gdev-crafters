﻿using CookieClicker.Runtime.Model;

namespace CookieClicker.Runtime.Presenter
{
	public class PurchaseAutoclicker
	{
		readonly Jar jar;

		public PurchaseAutoclicker(Jar jar)
		{
			this.jar = jar;
		}

		public void Execute()
		{
			jar.PurchaseAutoclicker();
		}
	}
}
