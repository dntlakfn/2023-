using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpon : MonoBehaviour
{
    public GameObject player;
    public static bool l = false;
    // Start is called before the first frame update
    void Start()
    {
        if (l)
        {
            Debug.Log("시발");
            player = SceneChange.player;
            l = false;
        }
        
        player = Instantiate(player, transform.position, Quaternion.identity);
       
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
