using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIscoreManage_qpalau : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.score = GameManager.score + 1;
            Debug.Log(GameManager.score);
        }
    }
}
