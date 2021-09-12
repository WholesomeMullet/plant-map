using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public int itemID;              // 아이템의 고유 ID값. 중복 불가능
    public string itemName;         // 아이템 이름. 중복 가능
    public string itemDescription;  // 아이템 설명
    public int itemCount;           // 소지 개수
    public Sprite itemIcon;         // 아이템의 아이콘

    public Item(int _itemID, string _itemName, string _itemDes, int _itemCount = 1)
    {

        itemID = _itemID;
        itemName = _itemName;
        itemDescription = _itemDes;
        itemCount = _itemCount;
        itemIcon = Resources.Load("ItemIcon/" + _itemID.ToString(), typeof(Sprite)) as Sprite;
    }
}

public class DatabaseManager : MonoBehaviour
{
    static public DatabaseManager instance;

    [SerializeField]
    public Item[] item1;

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

    // public List<ObItem> itemList = new List<ObItem>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
