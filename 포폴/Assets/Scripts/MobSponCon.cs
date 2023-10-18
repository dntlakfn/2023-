using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSponCon : MonoBehaviour
{
    public Rigidbody mob;
    public float sponTime; // 몹 스폰 주기
    public static float currentTime; // 감소하는 시간
    public float time;
    public static float limit = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        // F키 누르면 시작;
        if (Input.GetKey(KeyCode.F))
        {
            if (currentTime <= 1)
            {
                time = 100;
                currentTime = time;
                sponTime -= GameManager.stage / 10;
                GameManager.stage += 1;
                SceneChange.pass = false;
                limit = 0;
                
            }
        }

        currentTime -= Time.deltaTime; // 시간 감소

        // 시간이 끝나지 않고 몹 스폰 주기가 지나면 몹 스폰
        if(currentTime <= time - sponTime && currentTime >= 0)
        {
            StartCoroutine(Wait(sponTime));
            time -= sponTime;
        }
        
        // 스테이지 시작시 상점 출입 불가능
        if (currentTime <= 1)
        {
            SceneChange.pass = true;
        }

        // 기지 채력 없으면 스테이지 실패 (다시 원래 스테이지로 돌아감)
        if(HP.basehp == 0)
        {
            time = 0;
            currentTime = 0;
            GameManager.stage -= 1;
        }

        // 4스테이지 지나면 몹 스포너 추가 생성
        if (GameManager.stage % 5 == 0 && GameManager.stage != 0 && limit == 0)
        {
            limit = 1;
            Instantiate(gameObject, transform.position, Quaternion.identity);
        }

            
        
    }

    // 몹 스폰
    IEnumerator Wait(float sponSpeed)
    {
        yield return new WaitForSeconds(sponSpeed);
        Instantiate(mob, transform.position, Quaternion.identity);
        
    }
}
