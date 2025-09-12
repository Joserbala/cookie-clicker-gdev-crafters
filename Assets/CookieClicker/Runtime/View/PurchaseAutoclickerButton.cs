using CookieClicker.Runtime.Presenter;
using UnityEngine;
using UnityEngine.UI;

namespace CookieClicker.Runtime.View
{
	public class PurchaseAutoclickerButton : MonoBehaviour
	{
		[SerializeField] Button button;

		public void Initialize(PurchaseAutoclicker purchaseAutoclicker)
		{
			button.interactable = false;
			button.onClick.AddListener(purchaseAutoclicker.Execute);
		}
	}
}
