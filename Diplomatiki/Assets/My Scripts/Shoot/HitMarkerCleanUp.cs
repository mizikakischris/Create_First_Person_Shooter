﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMarkerCleanUp : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
