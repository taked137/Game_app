using UnityEngine;
using System.Collections;
using packt.UI;
using packt.Managers;
using System;
using System.Collections.Generic;
using festival.monster;

namespace packt.Controllers
{
    public class ResultSceneController : MonoBehaviour
    {
        public ResultInfo resultInfo;
        void Start()
        {
            print("result start");
            API.putMonsterGet(BattleSceneController.kindId).flod(
                result => {
                    print("not error");
                    resultInfo.SetText(result.text);
                    resultInfo.SetImage(result.modelId);
                }, error => {
                    ErrorHandle.handle(error);
                });
        }

        public void OnCloseResult()
        {
            GameManager.Instance.CloseMe(this);
        }
    }
}
