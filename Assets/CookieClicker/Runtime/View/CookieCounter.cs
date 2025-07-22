using CookieClicker.Runtime.Presenter;
using TMPro;
using UnityEngine;

namespace CookieClicker.Runtime.View
{
	public class CookieCounter : MonoBehaviour, ICookieCounterView
	{
		[SerializeField] TMP_Text text;
		PassTime passTime;

		public void Initialize(PassTime inPassTime)
		{
			passTime = inPassTime;
		}

		public void Refresh(int amount)
		{
			text.text = amount.ToString();
		}

		void Update()
		{
			passTime.Execute(Time.deltaTime);
		}
	}
}
