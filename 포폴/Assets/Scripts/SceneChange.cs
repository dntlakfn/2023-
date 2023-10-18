using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string s;
    public static bool pass = true;
    public static GameObject player;
    
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
         if (other.gameObject.tag == "Player" && pass)
        {
            
            SC();
        }
        
           
    }

    public void SC()
    {
       SceneManager.LoadScene(s);
    }
}
