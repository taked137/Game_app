using UnityEngine;
using System.Collections;
using packt.UI;
using packt.Managers;
using System;
using System.Collections.Generic;
using festival.monster;

namespace packt.Controllers
{
    public class InventorySceneController : MonoBehaviour
    {
        public InventoryContent inventoryContent;
        void Start()
        {

            API.getKinds().flod(
                result => {
                    var monsters = result;
                    if(inventoryContent != null) {
                        inventoryContent.FillInventory(monsters);
                        print("fillinventory called"); 
                    }
                }, error => {
                        ErrorHandle.handle(error);
                });
        }

        public void OnCloseInventory()
        {
            GameManager.Instance.CloseMe(this);
        }

        public void ResetScene()
        {
            print("ResetSceneメソッド起動"); 
            if (inventoryContent != null)
            {
                inventoryContent.ClearInventory();
            }
            Start();
        }
    }
}
