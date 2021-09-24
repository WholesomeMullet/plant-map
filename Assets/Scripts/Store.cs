using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    private Text myPoint;

    // Start is called before the first frame update
    void Start()
    {
        myPoint = GameObject.Find("userPoint").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetText() 
    {

    }

}
