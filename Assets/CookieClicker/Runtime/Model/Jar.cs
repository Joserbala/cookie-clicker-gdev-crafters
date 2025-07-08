using System;

namespace CookieClicker.Runtime.Model
{
	public class Jar
	{
		public int Amount { get; private set; }
		float timePassed;
		bool isAutoclickerPurchased;

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
			var CookiesToAdd = (int)timePassed;
			Amount += CookiesToAdd;
			timePassed -= CookiesToAdd;
		}
	}
}
