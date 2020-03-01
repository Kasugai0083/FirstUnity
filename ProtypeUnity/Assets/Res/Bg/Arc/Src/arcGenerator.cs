using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static pirceBase;

public class arcGenerator : MonoBehaviour
{
    
    public GameObject grass_solidPrefab;
    public GameObject grassPrefab;
    public GameObject solidPrefab;

    public bool[] Reverse = { false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {

        int randam_generate = 0;
        randam_generate = Random.Range(0,(int)Attribute.ETC);

        GameObject arc1 = Instantiate(grassPrefab) as GameObject;
        GameObject arc2 = Instantiate(grassPrefab) as GameObject;
        GameObject arc3 = Instantiate(solidPrefab) as GameObject;
        GameObject arc4 = Instantiate(grass_solidPrefab) as GameObject;

        arc1.transform.Rotate(0, 0, 0);
        arc2.transform.Rotate(0, 0, 90);
        arc3.transform.Rotate(0, 0, 180);
        arc4.transform.Rotate(0, 180, 270);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
