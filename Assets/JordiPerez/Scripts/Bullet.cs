using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public GameObject padre;
    public CanvasUpdateJPerez cVJP;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Speed * Time.deltaTime);
        Destroy(padre, 1);
    }

     
    


}
