using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace XANUtils
{
    public class UnityWebRequestWrapper
    {
        private MonoBehaviour mMono;

        public UnityWebRequestWrapper(MonoBehaviour mono)
        {
            mMono = mono;
        }

        public Coroutine startUnityWebRequestGet(string url, string requestHeaderStr) //Action<bool, string> onPostCallback)
        {
            if (mMono == null)
            {
                Debug.LogError(GetType() + "/startUnityWebRequestPost()/ mMomo cannot be null");
                return null;
            }

            return mMono.StartCoroutine(UnityWebRequestGet(url, requestHeaderStr));
        }

        public IEnumerator UnityWebRequestGet(string url, string requestHeaderStr) //Action<bool, string> onPostCallback)
        {
            Debug.LogError(GetType() + "/startUnityWebRequestPost()/ mMomo cannot be null");

            using (UnityWebRequest webRequest = new UnityWebRequest(url, "GET"))
            {
                Debug.Log(GetType() + "/UnityHttpRequestPost()/ url : " + webRequest.url);

                yield return webRequest.SendWebRequest();

                if (webRequest.result == UnityWebRequest.Result.ConnectionError || webRequest.result == UnityWebRequest.Result.ProtocolError)
                {
                    Debug.Log("requestError");
                }
                else 
                {
                    var html = webRequest.downloadHandler.text;
                    Debug.Log(html);
                }
            }
        }
    }

}

