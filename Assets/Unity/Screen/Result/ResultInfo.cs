using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

namespace packt.UI
{
    public class ResultInfo : MonoBehaviour
   {
        protected Text Text;
        protected RawImage Image;

        [Header("Texture model")] 
        public Texture modelId1;
        public Texture modelId2;
        public Texture modelId3;
        public Texture modelId4;
        public Texture modelId5;
        public Texture modelId6;
        public Texture modelId7;
        public Texture modelId8;
        public Texture modelId9;
        public Texture modelId10;
        public Texture modelId11;
        public Texture modelId12;
        public Texture modelId13;
        public Texture modelId14;
        public Texture modelId15;
        public Texture modelId16;
        public Texture modelId17;
        public Texture modelId18;
        public Texture modelId19;
        public Texture modelId20;
        public Texture modelId21;
        public Texture modelId22;
        public Texture modelId23;
        public Texture modelId24;
        public Texture modelId25;
        private List<Texture> textureList;
        void Start()
        {
            Text = transform.Find("Text").gameObject.GetComponent<Text>();
            Image = transform.Find("RawImage").gameObject.GetComponent<RawImage>();            
        }
        public void SetText(string text)
        {
            Text.text = text;
            print("textセット済");
        }
        public void SetImage(string modelId)
        {
            print("SetImage");
            textureList = new List<Texture>(); 
            textureList.Add(modelId1); 
            textureList.Add(modelId2);
            textureList.Add(modelId3);
            textureList.Add(modelId4);
            textureList.Add(modelId5);
            textureList.Add(modelId6);
            textureList.Add(modelId7);
            textureList.Add(modelId8);
            textureList.Add(modelId9);
            textureList.Add(modelId10);
            textureList.Add(modelId11);
            textureList.Add(modelId12);
            textureList.Add(modelId13);
            textureList.Add(modelId14);
            textureList.Add(modelId15);
            textureList.Add(modelId16);
            textureList.Add(modelId17);
            textureList.Add(modelId18);
            textureList.Add(modelId19);
            textureList.Add(modelId20);
            textureList.Add(modelId21);
            textureList.Add(modelId22);
            textureList.Add(modelId23);
            textureList.Add(modelId24);
            textureList.Add(modelId25);

            Image.texture = textureList[int.Parse(modelId)-1];
        }
    }
}
