using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamgeUp : MonoBehaviour
{
    public float NeedMoney = 500;
    public TextMeshProUGUI t2;
    float count = 1;
    // Start is called before the first frame update
    void Start()
    {
        t2.text = "Damge UP (+5) " + NeedMoney + "$";
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void DamgeUpgrade()
    {
        if (MONEY.money >= NeedMoney)
        {
            FireCon.damge += 5;
            count += 1;
            MONEY.money -= NeedMoney;
            NeedMoney *= count;
            t2.text = "Damge UP (+5) " + NeedMoney + "$";
            
        }
    }
}
