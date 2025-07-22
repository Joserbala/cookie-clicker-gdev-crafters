using CookieClicker.Runtime.Presenter;
using UnityEngine;
using UnityEngine.UI;

namespace CookieClicker.Runtime.View
{
	public class EarnCookieButton : MonoBehaviour
	{
		[SerializeField] Button cookieButton;

		public void Initialize(EarnCookie earnCookie)
		{
			cookieButton.onClick.AddListener(earnCookie.Execute);
		}
	}
}
