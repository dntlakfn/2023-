using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobCon : MonoBehaviour
{
    public Transform target;
    public BulletCon bullet;
    public float dropMoney = 50;
    NavMeshAgent navi;
    public float hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        navi = GetComponent<NavMeshAgent>();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        // 몹이 베이스 까지 쫒아감
        navi.SetDestination(target.position); 
        if (hp <= 0)
        {
            MONEY.money += dropMoney;
            Destroy(gameObject);
        }

        if (GameManager.stage % 4 == 0 && MobSponCon.limit == 0)
        {
            hp += 20;
            dropMoney += 50;
        }
        
    }

    public void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "Bullet")
        {
            hp -= FireCon.damge;
        }
        else if(other.gameObject.tag == "Base")
        {
            HP.basehp -= 1;
            Destroy(gameObject);
        }
           
    }
}
