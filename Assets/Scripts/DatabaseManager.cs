using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public int itemID;              // �������� ���� ID��. �ߺ� �Ұ���
    public string itemName;         // ������ �̸�. �ߺ� ����
    public string itemDescription;  // ������ ����
    public int itemCount;           // ���� ����
    public Sprite itemIcon;         // �������� ������

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

    // 1. �� �̵�
    // 2. ���̺�� �ε�
    // 3. �̸� �����θ� ���ϴ�. ������.

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
