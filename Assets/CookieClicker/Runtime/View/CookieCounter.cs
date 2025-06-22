using System;
using CookieClicker.Runtime.Model;
using CookieClicker.Runtime.Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CookieClicker.Runtime.View
{
	public class CookieCounter : MonoBehaviour, ICookieCounterView
	{
		[SerializeField] TMP_Text text;
		[SerializeField] Button cookieButton;
		PassTime passTime;

		void Awake()
		{
			var jar = new Jar();
			var earnCookie = new EarnCookie(jar, this);

			passTime = new PassTime(jar, this);
			cookieButton.onClick.AddListener(earnCookie.Execute);
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
