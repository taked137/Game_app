using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using packt.UI;
using packt.Managers;

namespace packt.Controllers
{
    public class UserRegisterSceneController : MonoBehaviour
    {

        // MARK: - Property

        public UserRegisterContent userRegisterContent;
        private bool isLoading = false;


        // MARK: - Lifecycle

        void Start()
        {
            userRegisterContent.postButton.onClick.AddListener(postButtonDidTap);
        }

        // MARK: - Private

        private void postButtonDidTap() {
            var text = userRegisterContent.inputField.text;
            if (text.Length == 0) {
                return;
            } else if (text.Length > 9) {
                return;
            }
            if (isLoading) { return; }
            isLoading = true;

            Auth.shared.signIn().flod(
                user => {
                    Debug.Log(user);
                    API.postUserRegister(text).flod(
                        result => {
                            Debug.Log(result);
                            PlayerPrefs.SetInt("isUserRegistered", 1);
                            PlayerPrefs.Save();
                            isLoading = false;
                            GameManager.Instance.OpenMap();
                        }, error => {
                            isLoading = false;
                            ErrorHandle.handle(error);
                        });
                }, error => {
                    isLoading = false;
                    ErrorHandle.handle(error);
                });
        }
    }
}
