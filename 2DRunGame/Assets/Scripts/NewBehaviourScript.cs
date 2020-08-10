using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    #region 欄位
    public float speed = 5;
    public int jump = 350;
    public float hp = 500;

    public bool isGround;
    public int coin;

    public AudioClip soundHit;
    public AudioClip soundSlide;
    public AudioClip soundJump;
    public AudioClip soundCoin;

    public Text textCoin;

    public Animator ani;
    public Rigdbody2D rig;
    public CapsuleCollider2D cap;
    
    #endregion


    #region 方法
    private void Move()
    {

    }

    private void Jump()
    {

    }

    private void Slide()
    {

    }

    private void EatCoin()
    {

    }

    private void Hit()
    {

    }

    private void Dead()
    {

    }

    private void Pass()
    {

    }
    #endregion

    #region 事件
    private void Start()
    {

    }

    private void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collisuon.tag == "金幣") EatCoin();
    }
    #endregion



}
