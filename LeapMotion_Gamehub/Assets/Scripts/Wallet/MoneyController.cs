using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
    private int money;
    [SerializeField] private Text moneyT;
    public int Money
    {
        get { return money; }
        set { money = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (moneyT.text != money.ToString())
        //    moneyT.text = money.ToString();
    }
}
