using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    public GameObject cube;
    // Use this for initialization
    void Start()
    {
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            cube.SetActive(true);
        }
        if (Input.GetKey(KeyCode.P))
        {
            //오른족 버튼
            cube.SetActive(false);
        }
    }

}
