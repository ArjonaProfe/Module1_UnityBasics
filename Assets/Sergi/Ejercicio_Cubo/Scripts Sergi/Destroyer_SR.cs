using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_SR : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    
}
