using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCon : MonoBehaviour
{
    public TextMeshProUGUI t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MobSponCon.currentTime >= 0)
        {
            t.text = "" + MobSponCon.currentTime;
        }
        
    }
}
