using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCon : MonoBehaviour
{
    public GameObject head;
    public GameObject gunhead;

    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 총 획득
    public void OnTriggerEnter(Collider collider)
    {
        Vector3 headPosition = new Vector3(head.transform.position.x, 3.1f, head.transform.position.z);
        if (collider.name == "Collider")
        {
            gunhead = Instantiate(gunhead, headPosition, head.transform.rotation);
            Destroy(head);
            Destroy(gameObject);
        }
    }
}
