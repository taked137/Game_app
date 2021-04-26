using UnityEngine;
using System.Collections;
using packt.UI;
using packt.Managers;
using System;
using System.Collections.Generic;

namespace packt.Controllers
{
    public class UserInfoSceneController : MonoBehaviour
    {
        public PlayerInfoController playerInfoController;
        void Start()
        {
            API.getUser().flod(
                result => {
                    playerInfoController.SetName(result.name);
                    playerInfoController.SetLevel(result.grade);
                    playerInfoController.SetMonsterscount(result.monstersCount);   
                    playerInfoController.SetProgress(result.progress);         
                }, error => {
                    ErrorHandle.handle(error);
                });
        }
        public void OnCloseUserInfo()
        {
            GameManager.Instance.CloseUserInfo(this);
        }
    }
}
