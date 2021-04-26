using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using packt.Managers;

public class ResultButtonClick : MonoBehaviour
{
    public int result = 0;
    // 0 = 勝敗未決定
    // 1 = 勝利
    // -1 = 落単
    public void OnClick()
    {
        if (result == 1)
        {
            GameManager.Instance.OpenResult();
            result = 0;
        }
        else if (result == -1)
        {
            GameObject BattleScene = GameObject.Find("BattleScene");
            BattleScene.GetComponent<BattleSceneController>().AudioStop();
            GameManager.Instance.CloseMe(BattleScene.GetComponent<BattleSceneController>());
            result = 0;
        }
    }
}
