using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using festival.monster;
using packt.Controllers;
using packt.FoodyGO.PhysicsExt;

namespace festival.battle
{
    public class EnemyController : MonoBehaviour
    {
        private GameObject enemy;
        private string modelId;
        private int enemyMaxHP;
        private int enemyHP;
        [SerializeField]
        private GameObject HPBar;
        [SerializeField]
        private GameObject MonsterName;
        // // デバッグ用prefab
        // [SerializeField]
        // private GameObject DebugPrefab;
        // [SerializeField]
        // private string DebugModelId;

        void Awake()
        {
            // // デバッグ用敵オブジェクト生成
            // enemy = (GameObject)Instantiate(DebugPrefab);
            // enemy.GetComponent<festival.monster.Monster>().kind = new festival.monster.Kind("2", "線形代数", "2", "線形代数の説明文");
            // enemy.GetComponent<festival.monster.Monster>().kind.rank = 1;
            // enemy.GetComponent<festival.monster.Monster>().kind.modelId = DebugModelId;
            // enemy.GetComponent<festival.monster.Monster>().kind.name = "線形代数";
            
            enemy = MapController.SelectedMonster;
            createEnemy();
        }

        void Start()
        {
            enemyMaxHP = enemy.GetComponent<Monster>().kind.rank + 5;
            enemyHP = enemyMaxHP;
            HPBar.GetComponent<Slider>().value = 1.0f;
            MonsterName.GetComponent<Text>().text = enemy.GetComponent<Monster>().kind.name;
        }

        void createEnemy()
        {
            modelId = enemy.GetComponent<Monster>().kind.modelId;
            Transform enemyTransform = enemy.transform;
            enemyTransform.SetParent(this.GetComponent<Transform>());
            Rigidbody enemyRb = enemy.GetComponent<Rigidbody>();
            enemyRb.constraints = RigidbodyConstraints.FreezeAll;

            Vector3 pos = enemyTransform.position;
            Quaternion rot = enemyTransform.rotation;
            Vector3 scale = enemyTransform.localScale;

            switch (modelId)
            {
                case "1": // 応用音声処理
                    pos = new Vector3(3.9f, 2, 0);
                    rot = Quaternion.Euler(0, 90, 0);
                    scale = new Vector3(1, 1, 1);
                    break;
                case "2": // データベース論
                    pos = new Vector3(2.2f, 1, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(0.016f, 0.016f, 0.016f);
                    break;
                case "3": // 知能ロボット制御論
                    pos = new Vector3(0, 1, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(2, 2, 2);
                    break;
                case "4": // プログラミング1
                    pos = new Vector3(0, 1, 0);
                    rot = Quaternion.Euler(0, 150, 0);
                    scale = new Vector3(10, 10, 10);
                    break;
                case "5": // コンピュータアーキテクチャ
                    pos = new Vector3(0, 2, 0);
                    rot = Quaternion.Euler(-80, 30, 0);
                    scale = new Vector3(0.007f, 0.007f, 0.007f);
                    break;
                case "6": // 電気回路
                    pos = new Vector3(0, 2, 0);
                    rot = Quaternion.Euler(80, -150, 0);
                    scale = new Vector3(0.3f, 0.3f, 0.3f);
                    break;
                case "7": // 電力システム
                    pos = new Vector3(0, 0.11f, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(2.5f, 2.5f, 2.5f);
                    break;
                case "8": // 半導体工学
                    pos = new Vector3(0, 3.76f, -3);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(0.14f, 0.14f, 0.14f);
                    break;
                case "9": // エンジン工学
                    pos = new Vector3(-1, 2, 0);
                    rot = Quaternion.Euler(0, 120, 0);
                    scale = new Vector3(3, 3, 3);
                    break;
                case "10": // ロボット工学
                    pos = new Vector3(2, 0.2f, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(0.008f, 0.008f, 0.008f);
                    break;
                case "11": // 歴史意匠建築物
                    pos = new Vector3(0, 1.1f, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(0.4f, 0.4f, 0.4f);
                    break;
                case "12": // 鉄筋コンクリート構造学
                    pos = new Vector3(-2.68f, 0.13f, 0);
                    rot = Quaternion.Euler(-90, 0, 0);
                    scale = new Vector3(2.2f, 2.2f, 2.2f);
                    break;
                case "13": // 橋工学
                    pos = new Vector3(1, 0, 4);
                    rot = Quaternion.Euler(0, -70, 0);
                    scale = new Vector3(0.3f, 0.3f, 0.3f);
                    break;
                case "14": // 社会工学基礎
                    pos = new Vector3(-0.2f, 0.2f, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(5000, 5000, 5000);
                    break;
                case "15": // 都市デザイン学
                    pos = new Vector3(0, 0.12f, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(0.5f, 0.5f, 0.5f);
                    break;
                case "16": // 回折結晶学
                    pos = new Vector3(0, 1.5f, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(100, 100, 100);
                    break;
                case "17": // 電磁気学
                    pos = new Vector3(0, 2, 0);
                    rot = Quaternion.Euler(0, 140, 0);
                    scale = new Vector3(1, 1, 1);
                    break;
                case "18": // 流体力学
                    pos = new Vector3(1.3f, 1, 0);
                    rot = Quaternion.Euler(0, -160, 0);
                    scale = new Vector3(0.002f, 0.002f, 0.002f);
                    break;
                case "19": // 物理工学序論
                    pos = new Vector3(0, 0.5f, -5);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(15, 15, 15);
                    break;
                case "20": // 力学
                    pos = new Vector3(1, 0.2f, -15);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(10, 10, 10);
                    break;
                case "21": // 生科学
                    pos = new Vector3(0, 3, 0);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(6, 6, 6);
                    break;
                case "22": // 薬化学概論
                    pos = new Vector3(0, 0.3f, -3);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(7, 7, 7);
                    break;
                case "23": // 基礎有機化学
                    pos = new Vector3(-0.5f, 3, 0);
                    rot = Quaternion.Euler(90, 0, 0);
                    scale = new Vector3(0.7f, 0.7f, 0.7f);
                    break;
                case "24": // 生体現象科学
                    pos = new Vector3(0, 1.5f, -3);
                    rot = Quaternion.Euler(0, 30, 0);
                    scale = new Vector3(200, 200, 200);
                    break;
                case "25": // 分析化学
                    pos = new Vector3(0, 2.3f, -4);
                    rot = Quaternion.Euler(0, 0, 0);
                    scale = new Vector3(15, 15, 15);
                    break;
                default:
                    break;
            }

            enemyTransform.position = pos;
            enemyTransform.rotation = rot;
            enemyTransform.localScale = scale;

            enemy.GetComponent<CollisionMonsterReaction>().enabled = true;
            enemy.GetComponent<CollisionMonsterReaction>().SetBattleSceneObject();
        }

        public void OnMonsterHit()
        {
            enemyHP--;
            HPBar.GetComponent<Slider>().value = (float)enemyHP / (float)enemyMaxHP;
        }

        public int GetEnemyCurrentHP()
        {
            return enemyHP;
        }

        public void DestroyEnemy(){
            Destroy(enemy);
        }
        public string GetEnemyKindId()
        {
            return enemy.GetComponent<Monster>().kind.id;
        }
    }
}