using CookieClicker.Runtime.Presenter;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class GameView : MonoBehaviour, IsdgsdgsdgView
	{
		public void Refresh(int amount)
		{
			FindFirstObjectByType<CookieCounter>().Refresh(amount);
		}
	}
}
