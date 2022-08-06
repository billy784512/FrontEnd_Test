using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;


namespace XANUtils.TestSpace
{
    public class UI : MonoBehaviour
    {
        [DllImport("__Internal")]
        private static extern void Loaded();

        public void StartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void Exit()
        {
            Application.Quit();
        }

        public void Conn()
        {
            Loaded();
        }

        public void httpPost()
        {

        }

        public void httpPut()
        {

        }

        public void httpDel()
        {

        }
    }
}
