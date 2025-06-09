using CookieClicker.Runtime.Presenter;
using UnityEngine;
using UnityEngine.UI;

namespace CookieClicker.Runtime.View
{
	public class CookieCounter : MonoBehaviour, ICookieCounterView
	{
		[SerializeField] Text text;

		public void Refresh()
		{

		}
	}
}
