﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kumoController : MonoBehaviour
{
    public GameObject planet;

    // Start is called before the first frame update
    void Start()
    {
        this.planet = GameObject.Find("en");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 axis = new Vector3(0,0,1);

        transform.RotateAround(planet.transform.position, axis, gameData.MAP_SPEED * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(planet.transform.position, axis, -gameData.MAP_SPEED);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(planet.transform.position, axis, gameData.MAP_SPEED);
        }
    }
}