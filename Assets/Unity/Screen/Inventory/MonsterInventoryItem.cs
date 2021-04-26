using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using festival.monster;
using packt.Controllers;

namespace packt.UI
{
    public class MonsterInventoryItem : InventoryItem
    {
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
        public Texture isgetFalse;
        private List<Texture> textureList;
        private Kind kind;

        [Header("detail button")]
        public GameObject button;

        GameObject panel;
        GameObject detailobject;
        DetailObjectController doc;
        MonsterDetail mod;


        public override void SetContent(object value)
        {
            print("Setcontent now");
            Start();
            kind = value as Kind;
            //if (kind == null){
            //    print("kind null");
            //    return;
            //} 

            if(kind.isGet==false)
            {
                print("isGet false");
                Image.texture = isgetFalse;
                BottomText.text = "";
                button.SetActive(false);
                return;
            }
            BottomText.text = kind.name; 

            textureList = new List<Texture>(); 
            textureList.Add(modelId1);  //頭悪いけど許して、あとで変えます
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

            Image.texture = textureList[int.Parse(kind.modelId)];
        }

        public void OpenDetailScene()
        {
            print("detail scene open");

            panel = GameObject.Find("Panel");
            doc = panel.GetComponent<DetailObjectController>();
            doc.MDchangetext(kind.text);
            doc.MDchangepicture(Image.texture);
            doc.OnDetailObject();
            doc.OffExitButton();
        }
    }
}
