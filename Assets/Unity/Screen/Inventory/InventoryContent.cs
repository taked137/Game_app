using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

namespace packt.UI
{
    public class InventoryContent : MonoBehaviour
    {
        private GridLayoutGroup grid;
        private RectTransform rect;

        public ScrollRect scrollRect;
        public GameObject inventoryPrefab;
        private IEnumerable items;
        private List<GameObject> inventoryList;

        public void FillInventory(IEnumerable items)
        {
            grid = GetComponent<GridLayoutGroup>();
            rect = GetComponent<RectTransform>();
            scrollRect.verticalNormalizedPosition = 0;
            inventoryList = new List<GameObject>();
            var scaler = new Vector3(1, 1, 1);
                        
            foreach(var i in items)
            {
                GameObject item = (GameObject)Instantiate(inventoryPrefab, Vector3.zero, Quaternion.identity);
                item.transform.SetParent(grid.transform);
                item.GetComponent<InventoryItem>().SetContent(i);
                item.GetComponent<RectTransform>().localScale = scaler;
                item.transform.localPosition = Vector3.zero;
                inventoryList.Add(item);        
            }            
        }

        public void ClearInventory()
        {
            inventoryList.ForEach(go => Destroy(go));
            inventoryList.Clear();
        }

       
    }
}
