using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using packt.Managers;

namespace festival.battle
{
    public class ResultController : MonoBehaviour
    {
        [SerializeField]
        private GameObject resultImagePrefab;
        private GameObject resultImage;

        void WinBattle()
        {
            this.GetComponent<BattleSceneController>().AudioStop();
            this.GetComponent<BattleSceneController>().AudioPlay();            
            resultImage = Instantiate(resultImagePrefab, this.GetComponent<Transform>());
            resultImage.GetComponentInChildren<ResultImageChanger>().AttachWinImage();
            resultImage.GetComponentInChildren<ResultButtonClick>().result = 1; // result == 1: 勝利
            BattleSceneController.kindId = this.GetComponent<EnemyController>().GetEnemyKindId();
        }

        void LoseBattle()
        {
            resultImage = Instantiate(resultImagePrefab, this.GetComponent<Transform>());
            resultImage.GetComponentInChildren<ResultImageChanger>().AttachLoseImage();
            resultImage.GetComponentInChildren<ResultButtonClick>().result = -1; // result == -1: 敗北
        }

        public void ResultJudge()
        {
            if (this.GetComponent<EnemyController>().GetEnemyCurrentHP() == 0)
            {
                this.GetComponent<EnemyController>().DestroyEnemy();
                WinBattle();
            } 
            else if (this.GetComponent<PlayerController>().playerCurrentPencilCount == 0)
            {
                LoseBattle();
            }
        }
    }
}