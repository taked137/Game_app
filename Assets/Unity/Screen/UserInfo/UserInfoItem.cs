using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using packt.Controllers;

namespace packt.UI
{
    public class UserInfoItem : MonoBehaviour
    {
        protected Text PlayerName;
        protected Text Level;
        protected Text Monsterscount;
        protected Slider slider;

        
        public void Start()
        {
            PlayerName = transform.Find("PlayerName").gameObject.GetComponent<Text>();
            Level = transform.Find("Level").gameObject.GetComponent<Text>();   
            Monsterscount = transform.Find("Monsterscount").gameObject.GetComponent<Text>();   
            slider = GameObject.Find("Slider").GetComponent<Slider>();         
        }
        
        public virtual void SetName(string name)
        {
            
        }
        public virtual void SetLevel(int level)
        {
            
        }
        public virtual void SetMonsterscount(int monsterscount)
        {
            
        }

        public virtual void SetProgress(int progress)
        {
            
        }

    }
}
