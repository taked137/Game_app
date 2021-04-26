using UnityEngine;
using System.Collections;
using packt.UI;
using packt.Managers;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;
using packt.Controllers;
using System.Collections.Generic;


namespace packt.Controllers
{
    public class MapController : MonoBehaviour
    {
        public GameObject HomeButton;

        public AudioSource audio; 
        public static AudioSource audioSource;
        
        // Battleシーンに渡すオブジェクト
        public static GameObject SelectedMonster;

        public MapPlayerInfoController mapplayerinfocontroller;
        void Start()
        {
            SetAudio(audio);
            API.getUser().flod(
                result => {
                    mapplayerinfocontroller.SetName(result.name);
                    mapplayerinfocontroller.SetLevel(result.grade);  
                    mapplayerinfocontroller.SetProgress(result.progress);         
                }, error => {
                    ErrorHandle.handle(error);
                });
        }

        public void OpenUserInfo()
        {
            GameManager.Instance.OpenUserInfofromMap();
        }

        public static void SetSelectedMonster(GameObject monster)
        {
            SelectedMonster = monster;
        }

        public static void SetAudio(AudioSource audio)
        {
            audioSource = audio;
        }

        public static void AudioStop()
        {
            audioSource.Stop();   
        }
        public static void AudioStart()
        {
            audioSource.Play(); 
        }
//        void Awake()
//        {
//            StartCoroutine(HomeButtonSet());
//        }

//        IEnumerator HomeButtonSet(){
//            yield return new WaitForSeconds(5);
//            HomeButton.SetActive(true);
//        }
    }
}
