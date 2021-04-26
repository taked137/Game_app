using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using Newtonsoft.Json;
using System.Net.Http;
using festival.monster;

public class API {

    #if UNITY_IOS && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern string _getTerm();

    public async static Task<Term> getTerm() {
        return await Task.Run<Term>(() => {
            string json = _getTerm();
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<Term>(json);
        });
    }


    [DllImport("__Internal")]
    private static extern string _postUserRegister(string token, string userName);

    public async static Task<User> postUserRegister(string userName) {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<User>(() => {
            string json = _postUserRegister(token, userName);
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<User>(json);
        });
    }


    [DllImport("__Internal")]
    private static extern string _getUser(string token);

    public async static Task<User> getUser() {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<User>(() => {
            string json = _getUser(token);
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<User>(json);
        });
    }


    [DllImport("__Internal")]
    private static extern string _getMonsters(string token);

    public async static Task<List<Kind>> getKinds() {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<List<Kind>>(() => {
            string json = _getMonsters(token);
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<List<Kind>>(json);
        });
    }


    [DllImport("__Internal")]
    private static extern string _getMonstersMap(string token);

    public async static Task<List<Monster>> getMonstersMap() {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<List<Monster>>(() => {
            string json = _getMonstersMap(token);
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<List<Monster>>(json);
        });
    }


    [DllImport("__Internal")]
    private static extern string _putMonsterGet(string token, string Id);

    public async static Task<Kind> putMonsterGet(string Id) {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<Kind>(() => {
            string json = _putMonsterGet(token, Id);
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<Kind>(json);
        });
    }

    #elif UNITY_ANDROID && !UNITY_EDITOR
    private static AndroidJavaObject jo = new AndroidJavaObject("mr.take.myapiplugin.APIController");

    public async static Task<Term> getTerm() {
        return await Task.Run<Term>(() => {
            AndroidJNI.AttachCurrentThread();
            string json = jo.Call<string>("_getTerm");
            AndroidJNI.DetachCurrentThread();
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<Term>(json);
        });
    }

    public async static Task<User> postUserRegister(string userName) {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<User>(() => {
            AndroidJNI.AttachCurrentThread();
            string json = jo.Call<string>("_postUserRegister", token, userName);
            AndroidJNI.DetachCurrentThread();
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<User>(json);
        });
    }

    public async static Task<User> getUser() {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<User>(() => {
            AndroidJNI.AttachCurrentThread();
            string json = jo.Call<string>("_getUser", token);
            AndroidJNI.DetachCurrentThread();
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<User>(json);
        });
    }

    public async static Task<List<Kind>> getKinds() {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<List<Kind>>(() => {
            AndroidJNI.AttachCurrentThread();
            string json = jo.Call<string>("_getKinds", token);
            AndroidJNI.DetachCurrentThread();
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<List<Kind>>(json);
        });
    }

    public async static Task<List<Monster>> getMonstersMap() {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<List<Monster>>(() => {
            AndroidJNI.AttachCurrentThread();
            string json = jo.Call<string>("_getMonstersMap", token);
            AndroidJNI.DetachCurrentThread();
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<List<Monster>>(json);
        });
    }

    public async static Task<Kind> putMonsterGet(string Id) {
        var token = await Auth.shared.getIdToken();
        return await Task.Run<Kind>(() => {
            AndroidJNI.AttachCurrentThread();
            string json = jo.Call<string>("_putMonsterGet", token, Id);
            AndroidJNI.DetachCurrentThread();
            AppError.checkError(json);
            return JsonConvert.DeserializeObject<Kind>(json);
        });
    }

    #else

    private static HttpClient client = new HttpClient();

    private static string baseURL = "https://knotserver.herokuapp.com";

    public async static Task<Term> getTerm() {
        var response = await client.GetAsync($"{baseURL}/term");
        AppError.checkError((int)response.StatusCode);
        return JsonConvert.DeserializeObject<Term>(await response.Content.ReadAsStringAsync());
    }

    public async static Task<User> postUserRegister(string userName) {
        var token = await Auth.shared.getIdToken();
        var json = $"{{\"userName\":\"{userName}\"}}";
        var request = new HttpRequestMessage(HttpMethod.Post, $"{baseURL}/user/register");
        request.Content = new StringContent(json, Encoding.UTF8, @"application/json");
        request.Headers.Add(@"Authorization", $"Bearer {token}");
        var response = await client.SendAsync(request);
        AppError.checkError((int)response.StatusCode);
        return JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
    }

    public async static Task<User> getUser() {
        var token = await Auth.shared.getIdToken();
        var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/user/me");
        request.Headers.Add(@"Authorization", $"Bearer {token}");
        var response = await client.SendAsync(request);
        AppError.checkError((int)response.StatusCode);
        return JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
    }

    public async static Task<List<Kind>> getKinds() {
        var token = await Auth.shared.getIdToken();
        var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/monsters");
        request.Headers.Add(@"Authorization", $"Bearer {token}");
        var response = await client.SendAsync(request);
        var responseJson = await response.Content.ReadAsStringAsync();
        AppError.checkError((int)response.StatusCode);
        return JsonConvert.DeserializeObject<List<Kind>>(await response.Content.ReadAsStringAsync());
    }

    public async static Task<List<Monster>> getMonstersMap() {
        var token = await Auth.shared.getIdToken();
        var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/monsters/map");
        request.Headers.Add(@"Authorization", $"Bearer {token}");
        var response = await client.SendAsync(request);
        AppError.checkError((int)response.StatusCode);
        return JsonConvert.DeserializeObject<List<Monster>>(await response.Content.ReadAsStringAsync());
    }

    public async static Task<Kind> putMonsterGet(string id) {
        var token = await Auth.shared.getIdToken();
        var json = $"{{\"id\":\"{id}\"}}";
        var request = new HttpRequestMessage(HttpMethod.Put, $"{baseURL}/monsters/get");
        request.Content = new StringContent(json, Encoding.UTF8, @"application/json");
        request.Headers.Add(@"Authorization", $"Bearer {token}");
        var response = await client.SendAsync(request);
        AppError.checkError((int)response.StatusCode);
        return JsonConvert.DeserializeObject<Kind>(await response.Content.ReadAsStringAsync());
    }

    #endif
}