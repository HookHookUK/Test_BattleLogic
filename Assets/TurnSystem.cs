using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum OrderType
{
    Buy,
    Sell,
    Start,
    Attack,
    Hit,
    Kill,
    Die,
    Alive,
    End
}

public class TurnSystem : MonoBehaviour
{
    bool isGameOver;
    [SerializeField] GameObject player;
    [SerializeField] GameObject other;

    [SerializeField] GameObject[] playerCardPos;
    [SerializeField] GameObject[] otherCardPos;

    private void Awake()
    {
        playerCardPos = new GameObject[6];
        otherCardPos = new GameObject[6];
    }


    private void Start()
    {
        GameLoop();
    }

    private void GameLoop()
    {
        GameStart(); // 게임이 시작되면 최초 한번만 실행

        BattleOrder(); // 순서대로 전투

        if(!isGameOver)
        GoShop(); // 상점으로 가!
    }

    void GameStart()
    {
        // 상대방과 자신의 덱 동기화
        int whoFirst = Random.Range(0, 2);
        if(whoFirst == 0)
        {
            // 0번째가 1번
        }
        else
        {
            // 1번째가 1번

        }
        // 선공 후공 설정
    }

    void GoShop()
    {
        // 상점 씬으로 이동
    }

    public void OnBuy()
    {
        Debug.Log("OnBuy");
    }

    public void OnSell()
    {
        Debug.Log("OnSell");
    }

    void BattleOrder()
    {
        // 패시브(순서 상관없이 항상 발동) // 함수 X
        
        // 전투 시작시 - 글로벌
        OnStart();

        // 공격 시작 //
        for(int i = 0; i < 6; i++)
        {
            
        }
        // 공격시 == 공격을 성공했을 때
        OnAttack();
        // 피격시
        OnHit();

        // 처치시
        OnKill();
        // 사망시 
        OnDie();
        
        // 턴 종료시 - 글로벌
        OnEnd();

        // 생존시 - 글로벌 
        OnAlive();
    }

    void ProcessOrder(OrderType orderType)
    {
        for (int i = 0; i < 6; i++)
        {
            //1번째 부터 각 자리에 위치한 카드의 Onstart()를 호출한다.
            
            
        }
    }


    void OnStart()
    {
        Debug.Log("OnStart");

    }

    void OnAttack()
    {
        Debug.Log("OnAttack");
    }

    void OnHit()
    {
        Debug.Log("OnHit");
    }

    void OnKill()
    {
        Debug.Log("OnHit");
    }

    void OnDie()
    {
        Debug.Log("OnDie");
    }

    void OnAlive()
    {
        Debug.Log("OnAlive");
    }

    void OnEnd()
    {
        Debug.Log("OnEnd");
    }

}
