using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCon : MonoBehaviour
{
    public GameObject c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // 콜라이더 고정
        transform.eulerAngles = new Vector3(c.transform.rotation.x, 0, c.transform.rotation.y);
    }
}
