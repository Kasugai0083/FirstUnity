using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenPirce : pirceBase
{
    // Start is called before the first frame update
    void Start()
    {
        land_attribute = Attribute.GRASS;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.land_status == Status.WET)
        {
            Wet();
        }
        else
        {
            Wither();
        }
    }
}
