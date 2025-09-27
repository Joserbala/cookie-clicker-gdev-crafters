using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class GameView : MonoBehaviour, IGameView
	{
		public void Refresh(Jar jar)
		{
			FindFirstObjectByType<CookieCounter>().Refresh(jar.Amount);
			FindFirstObjectByType<PurchaseAutoclickerButton>().Refresh(jar.Amount, jar.AutoclickerPrice);
		}
	}
}
