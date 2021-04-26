using UnityEngine;
using System.Collections;
using packt.UI;
using packt.Managers;
using System;

namespace packt.Controllers
{
    public class MenuSceneController : MonoBehaviour
    {
        void Start()
        {

        }

        //追加したメソッドです
        public void OnOpenInventory()
        {
            GameManager.Instance.OpenInventory();
        }
        public void OnOpenSetting()
        {
            GameManager.Instance.OpenSetting();
        }
        public void OnOpenUserInfo()
        {
            GameManager.Instance.OpenUserInfo();
        }
        public void OnCloseMenu()
        {
            GameManager.Instance.CloseMe(this);
        }

////        public void ResetScene()
////        {
////            if (inventoryContent != null)
////            {
////                inventoryContent.ClearInventory();
////            }
////            Start();
////        }
    }
}
