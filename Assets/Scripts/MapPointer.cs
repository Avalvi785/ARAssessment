using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(transform.position.x, 15, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
