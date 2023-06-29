using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoreScript : MonoBehaviour
{
    public int keyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        if(count <= keyCount)
        {
            if (transform.position.y < 2.5)
            {
                transform.position += Vector3.up * 0.05f;
            }
        }
    }
}
