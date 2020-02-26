using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kusaGenereter : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject kusa32Prefab;
    public GameObject tuti32Prefab;

    const int MapWidth = 34;
    const int MapHeight = 60;
    const int ChipSize = 32;

    public int[,] Map;
    private void Start()
    {
        float chip_x;
        float chip_y;

        Map = new int[MapHeight, MapWidth];

        for (int i = 0; i < MapHeight; i++)
        {
            for (int j = 0; j < MapWidth; j++)
            {

                chip_x = i * 0.3f;
                chip_y = j * 0.3f;
                //int chip_x = i * ChipSize;
                //int chip_y = j * ChipSize;

                Instantiate(kusa32Prefab, new Vector3(chip_x, chip_y, 0), Quaternion.identity);


            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject kusa = Instantiate(kusa32Prefab) as GameObject;
        //kusa.transform.position = new Vector3(0, 0, 0);
        //GameObject kusa = Instantiate(kusa32Prefab) as GameObject;
        //kusa.transform.position = new Vector3(chip_x, chip_y, 0);



    }
}
