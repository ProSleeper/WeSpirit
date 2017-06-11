using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CHARACTER_STATE
{
    IDLE,
    WALK,
    ATTACK,
    DIE
}

public class Attack : MonoBehaviour
{

    Animator Anim;
    public float MoveDirection;
    bool IsMove;
    int hp;
    int damage;
    int defence;

    public int DAMAGE
    {
        get
        {
            return damage;
        }
        set
        {
            damage += value;
        }
    }

    public int DEFENCE
    {
        get
        {
            return defence;
        }
        set
        {
            defence += value;
        }
    }

    void Start()
    {
        Anim = this.GetComponent<Animator>();
        hp = 100;
        IsMove = true;

        DAMAGE = 10;
        DEFENCE = 5;
    }

    private void Update()
    {
        if (IsMove)
        {
            this.transform.parent.position += Vector3.right * Time.deltaTime * MoveDirection * 3;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Anim.SetInteger("State", (int)CHARACTER_STATE.ATTACK);
        IsMove = false;

        int tempDamage = DEFENCE - collision.GetComponent<Attack>().DAMAGE;

        hp += (tempDamage > 0 ? 0 : tempDamage);
        Debug.Log(hp);
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }

        Invoke("MoveBack", 0.65f);
        
    }


    void MoveBack()
    {
        this.transform.parent.position += Vector3.right * -MoveDirection * 3;
        IsMove = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Anim.SetInteger("State", (int)CHARACTER_STATE.IDLE);
    }
}
    
