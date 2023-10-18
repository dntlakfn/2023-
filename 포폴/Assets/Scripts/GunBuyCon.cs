using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBuyCon : MonoBehaviour
{
    public GameObject player;
    public float price;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && MONEY.money >= price)
        {
            MONEY.money -= price;
            price = 0;
            PlayerSpon.l = true;
            SceneChange.player = player;
            Instantiate(player, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
           
    }
}
