using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using packt.Controllers;
using System;

namespace packt.UI
{
    public class MapPlayerInfoController : MapUserInfoItem
    {
         public override void SetName(string name)
        {
            PlayerName.text=name;   
            print("名前設定済");
        }
        public override void SetLevel(int level)
        {
            Level.text=Convert.ToString(level);
            print("レベル設定済");
        }
        public override void SetProgress(int progress)
        {
            slider.value = (float)(progress*0.001);
            print("progress設定済");
        }
    }
}
