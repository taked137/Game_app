using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        API.getTerm().flod(
            result => {
                Debug.Log($"getTerm result: {result}");
            }, error => {
                Debug.LogError($"getTerm error: {error}");
            });

        API.postUserRegister("").flod(
            result => {
                Debug.Log($"postUserRegister result: {result}");
            }, error => {
                Debug.LogError($"postUserRegister error: {error}");
            });

        API.getUser().flod(
            result => {
                Debug.Log($"getUser result: {result}");
            }, error => {
                Debug.LogError($"getUser error: {error}");
            });

        API.getKinds().flod(
            result => {
                Debug.Log($"getMonsters result: {result}");
            }, error => {
                Debug.LogError($"getMonsters error: {error}");
            });

        API.getMonstersMap().flod(
            result => {
                Debug.Log($"getMonstersMap result: {result}");
            }, error => {
                Debug.LogError($"getMonstersMap error: {error}");
            });

        API.putMonsterGet("").flod(
            result => {
                Debug.Log($"putMonsterGet result: {result}");
            }, error => {
                Debug.LogError($"putMonsterGet error: {error}");
            });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
