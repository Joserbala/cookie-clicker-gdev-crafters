using System;

namespace CookieClicker.Runtime.Model
{
	public class Jar
	{
		public int Amount { get; private set; }
		float timePassed;
		public bool isAutoclickerPurchased;

		public bool IsEmpty()
		{
			return Amount == 0;
		}

		public void Add()
		{
			Amount++;
		}

		public void OneSecondHasPassed()
		{
			Amount++;
		}

		public void SecondsHavePassed(float f)
		{
			if (!isAutoclickerPurchased)
				return;

			timePassed += f;
			var cookiesToAdd = (int)timePassed;
			Amount += cookiesToAdd;
			timePassed -= cookiesToAdd;
		}

		public void PurchaseAutoclicker()
		{
			isAutoclickerPurchased = true;
		}
	}
}
