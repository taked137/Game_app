using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using packt.UI;
using packt.Managers;

namespace packt.Controllers
{
    public class TitleSceneController : MonoBehaviour
    {
        // MARK: - Property

        public TitleContent titleContent;

        // MARK: - Lifecycle

        void Start()
        {
            if (Auth.shared.isSignedIn() && PlayerPrefs.HasKey("isUserRegistered")) {
                GameManager.Instance.OpenMapFromTitle();
                return;
            }
            
            titleContent.button.onClick.AddListener(buttonDidTap);
            titleContent.termLink.onClick.AddListener(termLinkDidTap);
        }

        // MARK: - Private

        private void buttonDidTap() {
            GameManager.Instance.OpenUserRegister();
        }

        private void termLinkDidTap() {
            Application.OpenURL("https://c0de-web.club.nitech.ac.jp/apps/meikoudaigoing/term/");
        }
    }
}