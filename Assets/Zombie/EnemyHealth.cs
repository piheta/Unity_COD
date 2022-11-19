using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth = 100;
    public Animator animator;


    public void dealDamage(int damage)
    {
        Debug.Log(currentHealth);
        currentHealth = currentHealth - damage;

        if (currentHealth <= 0)
        {
            animator.SetBool("dead", true);
            gameObject.GetComponent<NavMeshAgent>().enabled = false;
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
            Destroy(gameObject, 5);
        }
    }
}
