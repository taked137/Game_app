using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoShared;
using GoMap;
using festival.monster;
using packt.FoodyGO.PhysicsExt;

public class DropFeatures : MonoBehaviour
{
    public GOMap goMap;
    [SerializeField] private float timeOut;
    [SerializeField] private float timeElapsed;

    [SerializeField] private GameObject enemy_1;
    [SerializeField] private GameObject enemy_2;
    [SerializeField] private GameObject enemy_3;
    [SerializeField] private GameObject enemy_4;
    [SerializeField] private GameObject enemy_5;
    [SerializeField] private GameObject enemy_6;
    [SerializeField] private GameObject enemy_7;
    [SerializeField] private GameObject enemy_8;
    [SerializeField] private GameObject enemy_9;
    [SerializeField] private GameObject enemy_10;
    [SerializeField] private GameObject enemy_11;
    [SerializeField] private GameObject enemy_12;
    [SerializeField] private GameObject enemy_13;
    [SerializeField] private GameObject enemy_14;
    [SerializeField] private GameObject enemy_15;
    [SerializeField] private GameObject enemy_16;
    [SerializeField] private GameObject enemy_17;
    [SerializeField] private GameObject enemy_18;
    [SerializeField] private GameObject enemy_19;
    [SerializeField] private GameObject enemy_20;
    [SerializeField] private GameObject enemy_21;
    [SerializeField] private GameObject enemy_22;
    [SerializeField] private GameObject enemy_23;
    [SerializeField] private GameObject enemy_24;
    [SerializeField] private GameObject enemy_25;

    [SerializeField] private GameObject parentObject;
    public GOUVMappingStyle uvMappingStyle = GOUVMappingStyle.TopFitSidesRatio;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Debug.Log("最初の生成");
        // 敵スポーン
        respawnMonsters();

        Debug.Log("おわり");
        yield return StartCoroutine(goMap.locationManager.WaitForOriginSet());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // タイマー
        timeElapsed += Time.deltaTime;

        // 10秒おきに更新
        if (timeElapsed >= timeOut)
        {
            Debug.Log("タイマースタート");
            // 空にする
            destroyChild(parentObject);
            // 敵リスポーン
            respawnMonsters();
            // タイマーリセット
            timeElapsed = 0.0f;
            Debug.Log("タイマーリセット");
        }
    }

    // 敵生成
    void respawnMonsters()
    {
        // モンスター取得
        List<Monster> monsterList = new List<Monster>();
        API.getMonstersMap().flod(
            result =>
            {
                Debug.Log("1");
                // resultって変数名で値が使えます　API成功時の処理を書いてください
                monsterList = new List<Monster>(result);
                GameObject[] monsterArray = new GameObject[monsterList.Count];

                Debug.Log("モンスター生成");
                // モンスター描画
                for (int i = 0; i < monsterArray.Length; i++)
                {
                    monsterArray[i] = searchMonsterModel(monsterList[i]);
                    dropEnemy(monsterList[i], monsterArray[i]);
                }
            }, error =>
            {
                ErrorHandle.handle(error);
                // errorって変数名でエラーが使えます　API失敗時の処理を書いてください
                Debug.Log(error);
            });

        // リサイズ用
        // monsterList.Add(new Monster("25", "35.43434", "136.44443", new Kind("0", "0", "0", "0")));
        // GameObject monsterArray = searchMonsterModel(monsterList[0]);
        // dropEnemy(monsterList[0], monsterArray);
    }

    // 敵のインスタンス化
    private GameObject searchMonsterModel(Monster keyMonster)
    {
        Debug.Log("モデル検索");
        // モンスターIDごとに割り当て
        switch (keyMonster.id)
        {
            case "1":
                GameObject enemy_1Alter = GameObject.Instantiate(enemy_1);
                enemy_1Alter.transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
                enemy_1Alter.transform.localPosition = new Vector3(0, 4, 0);
                enemy_1Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_1Alter;
                break;

            case "2":
                GameObject enemy_2Alter = GameObject.Instantiate(enemy_2);
                enemy_2Alter.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
                enemy_2Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_2Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_2Alter;
                break;

            case "3":
                GameObject enemy_3Alter = GameObject.Instantiate(enemy_3);
                enemy_3Alter.transform.localScale = new Vector3(5.2f, 5.2f, 5.2f);
                enemy_3Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_3Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_3Alter;
                break;

            case "4":
                GameObject enemy_4Alter = GameObject.Instantiate(enemy_4);
                enemy_4Alter.transform.localScale = new Vector3(27f, 27f, 27f);
                enemy_4Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_4Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_4Alter;
                break;

            case "5":
                GameObject enemy_5Alter = GameObject.Instantiate(enemy_5);
                enemy_5Alter.transform.localScale = new Vector3(0.025f, 0.025f, 0.025f);
                enemy_5Alter.transform.localPosition = new Vector3(0, 1, 0);
                enemy_5Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_5Alter;
                break;

            case "6":
                GameObject enemy_6Alter = GameObject.Instantiate(enemy_6);
                enemy_6Alter.transform.localScale = new Vector3(5f, 5f, 5f);
                enemy_6Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_6Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_6Alter;
                break;

            case "7":
                GameObject enemy_7Alter = GameObject.Instantiate(enemy_7);
                enemy_7Alter.transform.localScale = new Vector3(4.5f, 4.5f, 4.5f);
                enemy_7Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_7Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_7Alter;
                break;

            case "8":
                GameObject enemy_8Alter = GameObject.Instantiate(enemy_8);
                enemy_8Alter.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
                enemy_8Alter.transform.localPosition = new Vector3(0, 9, 0);
                enemy_8Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_8Alter;
                break;

            case "9":
                GameObject enemy_9Alter = GameObject.Instantiate(enemy_9);
                enemy_9Alter.transform.localScale = new Vector3(7f, 7f, 7f);
                enemy_9Alter.transform.localPosition = new Vector3(0, 4, 0);
                enemy_9Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_9Alter;
                break;

            case "10":
                GameObject enemy_10Alter = GameObject.Instantiate(enemy_10);
                enemy_10Alter.transform.localScale = new Vector3(0.03f, 0.03f, 0.03f);
                enemy_10Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_10Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_10Alter;
                break;

            case "11":
                GameObject enemy_11Alter = GameObject.Instantiate(enemy_11);
                enemy_11Alter.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                enemy_11Alter.transform.localPosition = new Vector3(0, 2, 0);
                enemy_11Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_11Alter;
                break;

            case "12":
                GameObject enemy_12Alter = GameObject.Instantiate(enemy_12);
                enemy_12Alter.transform.localScale = new Vector3(7f, 7f, 7f);
                enemy_12Alter.transform.localPosition = new Vector3(0, 2, 0);
                enemy_12Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_12Alter;
                break;

            case "13":
                GameObject enemy_13Alter = GameObject.Instantiate(enemy_13);
                enemy_13Alter.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                enemy_13Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_13Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_13Alter;
                break;

            case "14":
                GameObject enemy_14Alter = GameObject.Instantiate(enemy_14);
                enemy_14Alter.transform.localScale = new Vector3(20000f, 20000f, 20000f);
                enemy_14Alter.transform.localPosition = new Vector3(0, 2, 0);
                enemy_14Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_14Alter;
                break;

            case "15":
                GameObject enemy_15Alter = GameObject.Instantiate(enemy_15);
                enemy_15Alter.transform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
                enemy_15Alter.transform.localPosition = new Vector3(0, 1, 0);
                enemy_15Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_15Alter;
                break;

            case "16":
                GameObject enemy_16Alter = GameObject.Instantiate(enemy_16);
                enemy_16Alter.transform.localScale = new Vector3(500f, 500f, 500f);
                enemy_16Alter.transform.localPosition = new Vector3(0, 1, 0);
                enemy_16Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_16Alter;
                break;

            case "17":
                GameObject enemy_17Alter = GameObject.Instantiate(enemy_17);
                enemy_17Alter.transform.localScale = new Vector3(4f, 4f, 4f);
                enemy_17Alter.transform.localPosition = new Vector3(0, 7, 0);
                enemy_17Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_17Alter;
                break;

            case "18":
                GameObject enemy_18Alter = GameObject.Instantiate(enemy_18);
                enemy_18Alter.transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
                enemy_18Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_18Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_18Alter;
                break;

            case "19":
                GameObject enemy_19Alter = GameObject.Instantiate(enemy_19);
                enemy_19Alter.transform.localScale = new Vector3(110f, 110f, 110f);
                enemy_19Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_19Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_19Alter;
                break;

            case "20":
                GameObject enemy_20Alter = GameObject.Instantiate(enemy_20);
                enemy_20Alter.transform.localScale = new Vector3(30f, 30f, 30f);
                enemy_20Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_20Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_20Alter;
                break;

            case "21":
                GameObject enemy_21Alter = GameObject.Instantiate(enemy_21);
                enemy_21Alter.transform.localScale = new Vector3(20f, 20f, 20f);
                enemy_21Alter.transform.localPosition = new Vector3(0, 6, 0);
                enemy_21Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_21Alter;
                break;

            case "22":
                GameObject enemy_22Alter = GameObject.Instantiate(enemy_22);
                enemy_22Alter.transform.localScale = new Vector3(40f, 40f, 40f);
                enemy_22Alter.transform.localPosition = new Vector3(0, 0, 0);
                enemy_22Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_22Alter;
                break;

            case "23":
                GameObject enemy_23Alter = GameObject.Instantiate(enemy_23);
                enemy_23Alter.transform.localScale = new Vector3(3f, 3f, 3f);
                enemy_23Alter.transform.localPosition = new Vector3(0, 2, 0);
                enemy_23Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_23Alter;
                break;

            case "24":
                GameObject enemy_24Alter = GameObject.Instantiate(enemy_24);
                enemy_24Alter.transform.localScale = new Vector3(920f, 920f, 920f);
                enemy_24Alter.transform.localPosition = new Vector3(0, 2, 0);
                enemy_24Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_24Alter;
                break;

            case "25":
                GameObject enemy_25Alter = GameObject.Instantiate(enemy_25);
                enemy_25Alter.transform.localScale = new Vector3(90f, 90f, 90f);
                enemy_25Alter.transform.localPosition = new Vector3(0, 13, 0);
                enemy_25Alter.GetComponent<Rigidbody>().isKinematic = true;
                return enemy_25Alter;
                break;

            default:
                return new GameObject();
                break;
        }
    }

    // 敵配置
    void dropEnemy(Monster monster, GameObject obj)
    {
        obj.transform.SetParent(parentObject.transform);
        Debug.Log("親");
        // obj.AddComponent<Monster>();
        obj.GetComponent<Monster>().id = monster.id;
        obj.GetComponent<Monster>().latitude = monster.latitude;
        obj.GetComponent<Monster>().longitude = monster.longitude;
        obj.GetComponent<Monster>().kind = monster.kind;
        // Debug.Log(obj.GetComponent<Monster>().latitude + "#");

        Coordinates coordinates = new Coordinates(float.Parse(monster.latitude), float.Parse(monster.longitude));
        Debug.Log("敵配置");
        // マップに配置
        goMap.dropPin(coordinates, obj);
    }

    // 子要素削除
    void destroyChild(GameObject parent)
    {
        //parentには削除したい子オブジェクトたちの親オブジェクトを指定する
        //子オブジェクトを全部消す
        foreach (Transform childTransform in parent.transform)
        {
            Destroy(childTransform.gameObject);
            Debug.Log("子要素削除");
        }
    }
}