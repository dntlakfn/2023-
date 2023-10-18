using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammo : MonoBehaviour
{
    public TextMeshProUGUI t;
    public PlayerSpon playerspon;
    FireCon fire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fire = playerspon.player.transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).GetComponent<FireCon>();
        t.text = fire.currentAmmo + "/" + fire.maxAmmo;
    }
}
