using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace festival.battle
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private int playerMaxPencilCount;
        public int playerCurrentPencilCount;
        [SerializeField]
        private GameObject pencilCount;

        void Start()
        {
            playerCurrentPencilCount = playerMaxPencilCount + 1;
            pencilCount.GetComponent<Text>().text = playerCurrentPencilCount.ToString();
        }

        public void ThrowingPencil()
        {
            playerCurrentPencilCount--;
            pencilCount.GetComponent<Text>().text = playerCurrentPencilCount.ToString();
        }
    }
}