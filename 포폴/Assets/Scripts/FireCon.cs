using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCon : MonoBehaviour
{
    public float currentShotDelay;
    public float shotDelay = 0f;
    float time;
    
    public static float damge = 25;
    public float maxAmmo;
    public float currentAmmo;
    public float reroadTime;
    
    public GameObject bullet;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = maxAmmo;
        currentShotDelay = shotDelay;
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && currentAmmo == 0)
        {
            StartCoroutine(Reroad(reroadTime));
        }
        else if (Input.GetMouseButton(0) && currentShotDelay <= 0 && currentAmmo != 0)
        {   
            StartCoroutine(Wait());
            currentShotDelay = shotDelay;
        }
        currentShotDelay -= Time.deltaTime;
        
    }

    IEnumerator Wait()
    {
            Instantiate(bullet, transform.position, transform.rotation);
            currentAmmo -= 1f;
            yield return new WaitForSecondsRealtime(0);
        
    }

    IEnumerator Reroad(float reroadTime)
    {
        yield return new WaitForSecondsRealtime(reroadTime);
        currentAmmo = maxAmmo;

    }

    // Update is called once per frame
    
}
