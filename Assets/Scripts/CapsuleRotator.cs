﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotator : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(180,180,0) * Time.deltaTime);
    }
}
