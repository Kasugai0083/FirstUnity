using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPirce : pirceBase
{

    // Start is called before the first frame update
    void Start()
    {
        land_attribute = Attribute.DESERT;
    }

    // Update is called once per frame
    void Update()
    {
        Wither();
    }
}
