﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackPirce : pirceBase
{
    // Start is called before the first frame update
    void Start()
    {
        land_attribute = Attribute.SOLID;
    }

    // Update is called once per frame
    void Update()
    {
        Wither();
    }
}