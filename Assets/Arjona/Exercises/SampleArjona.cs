using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleArjona : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown("Jump"))
        {
            int r = Random.Range(0, waypoints.Length);
            Instantiate(prefab, waypoints[r].transform);
        }
    }
}
