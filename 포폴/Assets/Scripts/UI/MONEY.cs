using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MONEY : MonoBehaviour
{
    public TextMeshProUGUI t;
    public static float money = 100000;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        t.text = "Money: " + money;
    }

    public void GetMoney(float money1)
    {
        money = money + money1;
    }
}
