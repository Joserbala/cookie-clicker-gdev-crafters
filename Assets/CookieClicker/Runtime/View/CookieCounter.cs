using System;
using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace CookieClicker.Runtime.View
{
	public class CookieCounter : MonoBehaviour, ICookieCounterView
	{
		[SerializeField] TMP_Text text;
		PassTime passTime;
		[SerializeField] EarnCookieButton earnCookieButton;

		public void Initialize(EarnCookie earnCookie, PassTime inPassTime)
		{
			passTime = inPassTime;
			earnCookieButton.Initialize(earnCookie);
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
