using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using packt.Controllers;

namespace packt.UI
{
    public class InventoryItem : MonoBehaviour
    {
        protected Text BottomText;
        protected RawImage Image;
        
        public void Start()
        {
            BottomText = transform.Find("BottomText").gameObject.GetComponent<Text>();
            Image = transform.Find("RawImage").gameObject.GetComponent<RawImage>();            
        }
        
        public virtual void SetContent(object value)
        {
            
        }

    }
}
