using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    public Text HP;
    public int collisionCount = 3;

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "_obstacle" && collisionCount >0)
        {
            collisionCount--;
            HP.text = collisionCount.ToString();
        }
        if (collisionCount == 0)
        {
            FindObjectOfType<score>().stopScore(); 
            FindObjectOfType<gameManager>().EndGame(); 
        }
    }
}
