using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText; 

    bool stop = false;
    void Update() 
    {
        if(!stop)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }

    public void stopScore()
    {
        stop = true;
    }
}
