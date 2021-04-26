using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using UnityEngine.EventSystems;
using packt.Controllers;

namespace packt.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        [Header("Splash Screen")]
        public bool ShowSplashScreen = true;
        public string SplashSceneName;

        [Header("Game Scenes")]
        public string BattleSceneName;
        public string InventorySceneName;
        public string MapSceneName;
        public string MenuSceneName;
        public string ResultSceneName;
        public string SettingSceneName;
        public string TitleSceneName;
        public string UserRegisterSceneName;
        public string UserInfoSceneName;


        [Header("Layer Names")]
        public string MonsterLayerName = "Monster";



        private Scene SplashScene;
        private GameScene BattleScene;    
        private GameScene InventoryScene;   
        private GameScene MapScene;   
        private GameScene MenuScene;   
        private GameScene ResultScene;
        private GameScene SettingScene;
        private GameScene TitleScene;
        private GameScene UserRegisterScene;
        private GameScene UserInfoScene;
        private GameScene lastScene;
        void Start()
        {
            SceneManager.sceneLoaded += SceneManager_sceneLoaded; 

            if(ShowSplashScreen && string.IsNullOrEmpty(SplashSceneName)==false)
            {                
                SceneManager.LoadSceneAsync(SplashSceneName, LoadSceneMode.Additive);
            }
            else if (Auth.shared.isSignedIn() && PlayerPrefs.HasKey("isUserRegistered")) {
                SceneManager.LoadSceneAsync(MapSceneName, LoadSceneMode.Additive);
            }
            else if(string.IsNullOrEmpty(TitleSceneName) == false)
            {
                SceneManager.LoadSceneAsync(TitleSceneName, LoadSceneMode.Additive);
            }
        }
        private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode lsm)
        {            
            if (scene.name == SplashSceneName)
            {
                SplashScene = scene;
                StartCoroutine(DisplaySplashScene());
            }
            else if(scene.name == MapSceneName)
            {
                MapScene = new GameScene();
                MapScene.scene = scene;                          
            }
            else if(scene.name == InventorySceneName)
            {
                InventoryScene = new GameScene();
                InventoryScene.scene = scene;
            }
            else if (scene.name == BattleSceneName)
            {
                BattleScene = new GameScene();
                BattleScene.scene = scene;                
            } 
            else if(scene.name == MenuSceneName)
            {
                MenuScene = new GameScene();
                MenuScene.scene = scene;
            }
            else if(scene.name == ResultSceneName)
            {
                ResultScene = new GameScene();
                ResultScene.scene = scene;                          
            }
            else if(scene.name == SettingSceneName)
            {
                SettingScene = new GameScene();
                SettingScene.scene = scene;                          
            }
            else if(scene.name == TitleSceneName)
            {
                TitleScene = new GameScene();
                TitleScene.scene = scene;                          
            }
            else if(scene.name == UserInfoSceneName)
            {
                UserInfoScene = new GameScene();
                UserInfoScene.scene = scene;                          
            }
            else if(scene.name == UserRegisterSceneName)
            {
                UserRegisterScene = new GameScene();
                UserRegisterScene.scene = scene;                          
            }
        }

        public void OnHomeClicked()
        {
            print("HomeButtonClicked");
            
            SceneManager.LoadSceneAsync(MenuSceneName, LoadSceneMode.Additive);
        }
        //追加したメソッド
        public void OpenMap()
        {
            if(MapScene == null)
            {
                SceneManager.LoadSceneAsync(MapSceneName,LoadSceneMode.Additive);
            }
            else
            {
                MapScene.RootGameObject.SetActive(true);
                //var isc = MapScene.RootGameObject.GetComponent<MapSceneController>();
                //if(isc != null) isc.ResetScene();
            }
            UserRegisterScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(UserRegisterSceneName);
        }

        public void OpenMapFromTitle() {
            if(MapScene == null)
            {
                SceneManager.LoadSceneAsync(MapSceneName,LoadSceneMode.Additive);
            }
            else
            {
                MapScene.RootGameObject.SetActive(true);
                //var isc = MapScene.RootGameObject.GetComponent<MapSceneController>();
                //if(isc != null) isc.ResetScene();
            }
            TitleScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(TitleSceneName);
        }

        public void OpenUserRegister()
        {
            if(UserRegisterScene == null)
            {
                SceneManager.LoadSceneAsync(UserRegisterSceneName,LoadSceneMode.Additive);
            }
            else
            {
                UserRegisterScene.RootGameObject.SetActive(true);
                //var isc = MapScene.RootGameObject.GetComponent<MapSceneController>();
                //if(isc != null) isc.ResetScene();
            }
            TitleScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(TitleSceneName);
        }

        public void OpenInventory()
        {
            if(InventoryScene == null)
            {
                SceneManager.LoadSceneAsync(InventorySceneName,LoadSceneMode.Additive);
            }
            else
            {
                InventoryScene.RootGameObject.SetActive(true);
            //    var isc = InventoryScene.RootGameObject.GetComponent<InventorySceneController>();
            //    if(isc != null) isc.ResetScene();
            }
            MenuScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(MenuSceneName);
        }
        public void OpenSetting()
        {
            SceneManager.LoadSceneAsync(SettingSceneName,LoadSceneMode.Additive);
            MenuScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(MenuSceneName);
        }
        public void OpenUserInfo()
        {
            SceneManager.LoadSceneAsync(UserInfoSceneName,LoadSceneMode.Additive);
            MenuScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(MenuSceneName);
        }
        public void OpenUserInfofromMap()
        {
            SceneManager.LoadSceneAsync(UserInfoSceneName,LoadSceneMode.Additive);
        }

        public void OpenResult() //バトル勝利時に呼ぶ
        {
            MapController.AudioStart();

            if(ResultScene == null)
            {
                SceneManager.LoadSceneAsync(ResultSceneName,LoadSceneMode.Additive);
            }
            else
            {
                ResultScene.RootGameObject.SetActive(true);
            //    var usc = UserInfoScene.RootGameObject.GetComponent<UserInfoSceneController>();
            //    if(usc != null) isc.ResetScene();
            }
            BattleScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(BattleSceneName);
        }

        public void CloseSetting(SettingSceneController SettingSceneController)
        {
            SettingScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(SettingSceneName);
            MapScene.RootGameObject.SetActive(true);
        }
        public void CloseUserInfo(UserInfoSceneController UserInfoSceneController)
        {
            UserInfoScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(UserInfoSceneName);
            MapScene.RootGameObject.SetActive(true);
        }

        //追加したメソッド
        public void CloseMe(MenuSceneController MenuSceneController)
        {
            MenuScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(MenuSceneName);
            MapScene.RootGameObject.SetActive(true);
        }
        public void CloseMe(InventorySceneController inventorySceneController)
        {
            InventoryScene.RootGameObject.SetActive(false);
            MapScene.RootGameObject.SetActive(true);
        }
        public void CloseMe(ResultSceneController resultSceneController)
        {
            ResultScene.RootGameObject.SetActive(false);
            MapScene.RootGameObject.SetActive(true);
        }
        public void CloseMe(BattleSceneController BattleSceneController)  //バトル敗北時に呼ぶ
        {
            BattleScene.RootGameObject.SetActive(false);
            SceneManager.UnloadSceneAsync(BattleSceneName);
            MapScene.RootGameObject.SetActive(true);
            MapController.AudioStart();
        }

        //display the Splash scene and then load the game start scene
        IEnumerator DisplaySplashScene()
        {
            SceneManager.LoadSceneAsync(MapSceneName, LoadSceneMode.Additive);   
                        //set a fixed amount of time to wait before unloading splash scene   
                        //we could also check if the GPS service was started and running
                        //or any other requirement   
            yield return new WaitForSeconds(5);
            SceneManager.UnloadScene(SplashScene);       
        }
                
        /// <summary>
        /// Checks if a relevant game object has been hit
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>

        // // デバッグ用prefab
        // [SerializeField]
        // private GameObject DebugPrefab;
        public bool RegisterHitGameObject(Vector3 position)
        {
            // // デバッグ用値代入
            // var enemy = (GameObject)Instantiate(DebugPrefab);
            // enemy.GetComponent<festival.monster.Monster>().kind = new festival.monster.Kind("1", "線形代数", "1", "線形代数の説明文");
            // enemy.GetComponent<festival.monster.Monster>().kind.rank = 1;
            // enemy.GetComponent<festival.monster.Monster>().kind.modelId = "1";
            // enemy.GetComponent<festival.monster.Monster>().kind.name = "線形代数";
            // HandleHitGameObject(enemy);
            // return true;


            int mask = BuildLayerMask();
            Ray ray = Camera.main.ScreenPointToRay(position);            
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, mask))
            {
                print("Object hit " + hitInfo.collider.gameObject.name);
                var go = hitInfo.collider.gameObject;
                HandleHitGameObject(go);

                return true;
            }
            return false;
        }

        private void HandleHitGameObject(GameObject go)
        {
                print("HandleHitGameObjectは動いています"); 

                MapController.AudioStop();
    //        if(go.GetComponent<MonsterController>()!= null)
    //        {
                //check if the scene has already been run
                
                SceneManager.LoadSceneAsync(BattleSceneName, LoadSceneMode.Additive);

                // 選択したGameObjectをBattleシーンに渡す用のstatic変数に設定
                MapController.SetSelectedMonster(go);

                //remove the monster, he will either be caught or run away
            //    var mc = go.GetComponent<MonsterController>();
            //    mc.monsterService.RemoveMonster(mc.monsterSpawnLocation);
                MapScene.RootGameObject.SetActive(false);               
     //       }
        }
        
        private int BuildLayerMask()
        {
            return 1 << LayerMask.NameToLayer(MonsterLayerName);
        }
    }

    public class GameScene
    {
        public Scene scene;

        private GameObject _rootGameObject;
        public GameObject RootGameObject
        {
            get
            {
                if (scene.isLoaded == false) return null;
                if(_rootGameObject == null)
                {
                    _rootGameObject = scene.GetRootGameObjects()[0];
                }
                return _rootGameObject;
            }
        }

    }
}
