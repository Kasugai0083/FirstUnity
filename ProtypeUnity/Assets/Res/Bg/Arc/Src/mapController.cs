using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mapController : MonoBehaviour
{

    public GameObject grass_pirce;
    public GameObject solid_pirce;
    public GameObject grass_solid_pirce;

    // Start is called before the first frame update
    void Start()
    {
        this.grass_pirce = GameObject.Find("green_arcPrefab(Clone)");      
        this.solid_pirce = GameObject.Find("red_arcPrefab(Clone)");      
        this.grass_solid_pirce = GameObject.Find("grass_solidPrefab(Clone)");      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0,0,gameData.MAP_SPEED);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,0,-gameData.MAP_SPEED);
        }
    }
}
