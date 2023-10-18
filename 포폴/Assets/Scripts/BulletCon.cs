using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCon : MonoBehaviour
{
    public GameObject fire;
    public GameObject zom;
    public MobCon mc;
    public float damge;
    float shotSpeed = 4000;
    //public Vector3 s = new Vector3.Angle(fireAngle.rotation);
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * shotSpeed);
        mc = GetComponent<MobCon>();
    }

    // Update is called once per frame
    void Update()
    {
           
            
    }

    public void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
           
    }

    
}
