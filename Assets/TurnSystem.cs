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
        GameStart(); // ������ ���۵Ǹ� ���� �ѹ��� ����

        BattleOrder(); // ������� ����

        if(!isGameOver)
        GoShop(); // �������� ��!
    }

    void GameStart()
    {
        // ����� �ڽ��� �� ����ȭ
        int whoFirst = Random.Range(0, 2);
        if(whoFirst == 0)
        {
            // 0��°�� 1��
        }
        else
        {
            // 1��°�� 1��

        }
        // ���� �İ� ����
    }

    void GoShop()
    {
        // ���� ������ �̵�
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
        // �нú�(���� ������� �׻� �ߵ�) // �Լ� X
        
        // ���� ���۽� - �۷ι�
        OnStart();

        // ���� ���� //
        for(int i = 0; i < 6; i++)
        {
            
        }
        // ���ݽ� == ������ �������� ��
        OnAttack();
        // �ǰݽ�
        OnHit();

        // óġ��
        OnKill();
        // ����� 
        OnDie();
        
        // �� ����� - �۷ι�
        OnEnd();

        // ������ - �۷ι� 
        OnAlive();
    }

    void ProcessOrder(OrderType orderType)
    {
        for (int i = 0; i < 6; i++)
        {
            //1��° ���� �� �ڸ��� ��ġ�� ī���� Onstart()�� ȣ���Ѵ�.
            
            
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
