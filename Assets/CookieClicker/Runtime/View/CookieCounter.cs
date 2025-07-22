using CookieClicker.Runtime.Presenter;
using TMPro;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class CookieCounter : MonoBehaviour, ICookieCounterView
	{
		[SerializeField] TMP_Text text;

		public void Refresh(int amount)
		{
			text.text = amount.ToString();
		}
	}
}
