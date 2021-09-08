using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    static public DatabaseManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this; 
        }
    }

    // 1. 씬 이동
    // 2. 세이브와 로드
    // 3. 미리 만들어두면 편하다. 아이템.

    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches; 

    public List<Item> itemList = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
