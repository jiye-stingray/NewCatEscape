using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        //프래임마다 등속으로 낙하 시킨다
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나가면 오브젝트를 소멸 시킨다
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌");
        Destroy(gameObject);

        //감독 스크립트에 플레이어와 화살이 충돌했다고 전달한다
        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseHp();
    }
}
