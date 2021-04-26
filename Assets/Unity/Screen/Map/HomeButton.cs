using UnityEngine;
using System.Collections;
using packt.Managers;
using UnityEngine.UI;

namespace packt.UI
{
    [RequireComponent(typeof(Button))]
    public class HomeButton : MonoBehaviour
    {
        void Start()
        {
            var btn = GetComponent<Button>();
            btn.onClick.AddListener(OnClick);
        }
        public void OnClick()
        {
            GameManager.Instance.OnHomeClicked();
        }
    }
}
