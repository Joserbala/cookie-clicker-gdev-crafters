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
			var earnCookie = new EarnCookie(jar, cookieCounter);

			var passTime = new PassTime(jar, cookieCounter);

			cookieCounter.Initialize(earnCookie, passTime);
		}
	}
}
