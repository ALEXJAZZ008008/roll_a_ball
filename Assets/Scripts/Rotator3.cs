﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator3 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime);
    }
}