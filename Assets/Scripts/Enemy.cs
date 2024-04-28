using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform targetDestination;
    GameObject targetGameobject;
    Character targetCharacter;
    [SerializeField] float speed;

    Rigidbody2D rgbd2d;

    [SerializeField] int hp = 4;
    [SerializeField] int damage = 1;

    private void Awake()
    {
       rgbd2d = GetComponent<Rigidbody2D>();
        targetGameobject = targetDestination.gameObject;
       
    }

    private void FixedUpdate()
    {
        Vector3 direction = (targetDestination.position - transform.position).normalized;
        rgbd2d.velocity = direction * speed;
    }

    private void onCollissionStay2D(Collision2D collision)
    {
        if(collision.gameObject == targetGameobject)
        {
            Attack();
        }
    }

    private void Attack()
    {
        //Debug.Log("Attacking the character");
        if(targetCharacter == null)
        {
            targetCharacter = targetGameobject.GetComponent<Character>();
        }

        targetCharacter.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp < 1)
        {
            Destroy(gameObject);
        }
    }

}
