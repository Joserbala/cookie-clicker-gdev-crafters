using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class DependencyResolver : MonoBehaviour
	{
		void Awake()
		{
			var jar = new Jar();
			var cookieCounter = FindAnyObjectByType<CookieCounter>();
			var earnCookieButton = FindAnyObjectByType<EarnCookieButton>();
			var asFsdg = FindAnyObjectByType<ASFsdg>();
			var earnCookie = new EarnCookie(jar, cookieCounter);

			earnCookieButton.Initialize(earnCookie);

			var passTime = new PassTime(jar, cookieCounter);

			asFsdg.Initialize(passTime);

			var purchaseAutoclickerButton = FindAnyObjectByType<PurchaseAutoclickerButton>();
			var purchaseAutoclicker = new PurchaseAutoclicker(jar);
			purchaseAutoclickerButton.Initialize(purchaseAutoclicker);
		}
	}
}
