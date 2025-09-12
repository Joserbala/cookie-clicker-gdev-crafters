using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class DependencyResolver : MonoBehaviour
	{
		void Awake()
		{
			var cookieCounter = FindAnyObjectByType<CookieCounter>();
			var clock = FindAnyObjectByType<UnityClock>();
			var earnCookieButton = FindAnyObjectByType<EarnCookieButton>();
			var purchaseAutoclickerButton = FindAnyObjectByType<PurchaseAutoclickerButton>();

			var jar = new Jar(3);
			var purchaseAutoclicker = new PurchaseAutoclicker(jar);
			var earnCookie = new EarnCookie(jar, cookieCounter);
			var passTime = new PassTime(jar, cookieCounter);

			clock.Initialize(passTime);
			earnCookieButton.Initialize(earnCookie);
			purchaseAutoclickerButton.Initialize(purchaseAutoclicker);
		}
	}
}
