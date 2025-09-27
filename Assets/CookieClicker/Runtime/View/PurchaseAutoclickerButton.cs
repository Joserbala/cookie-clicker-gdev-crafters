using CookieClicker.Runtime.Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CookieClicker.Runtime.View
{
	public class PurchaseAutoclickerButton : MonoBehaviour
	{
		[SerializeField] Button button;
		TMP_Text tmpText;

		public void Refresh(int currentCookieAmount, int purchasePrice)
		{
			button.interactable = currentCookieAmount >= purchasePrice;
			tmpText.text = "Purchase Autoclicker " + purchasePrice;
		}

		public void Initialize(PurchaseAutoclicker purchaseAutoclicker)
		{
			tmpText = button.GetComponentInChildren<TMP_Text>();
			button.interactable = false;
			button.onClick.AddListener(purchaseAutoclicker.Execute);
		}
	}
}
