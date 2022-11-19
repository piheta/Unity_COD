using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAIWalking : MonoBehaviour
{

    NavMeshAgent nm;
    public Transform target;

    public enum AIState { idle , chasing, attack };

    public AIState aiState = AIState.idle;

    public float distanceTreshold = 10f;

    public float attackThreshold = 1f;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        StartCoroutine(Think());
        target = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Think() {
        while (true) 
        {
            switch (aiState)
            {
                case AIState.idle:
                    float dist = Vector3.Distance(target.position, transform.position);
                    if (dist < distanceTreshold)
                    {
                        aiState = AIState.chasing;
                        animator.SetBool("Chasing", true);
                    }
                    nm.SetDestination(transform.position);
                    break;
                case AIState.chasing:
                    dist = Vector3.Distance(target.position, transform.position);
                    if (dist > distanceTreshold)
                    {
                        aiState = AIState.idle;
                        animator.SetBool("Chasing", false);
                    }
                    
                    if (dist < attackThreshold) {
                        aiState = AIState.attack;
                        animator.SetBool("Attacking", true);
                    }
                    nm.SetDestination(target.position);
                    break;
                case AIState.attack:
                    Debug.Log("Attack");
                    nm.SetDestination(transform.position);
                    dist = Vector3.Distance(target.position, transform.position);
                    if (dist > attackThreshold) {
                        aiState = AIState.chasing;
                        animator.SetBool("Attacking", false);
                    }
                    break;
                default:
                    break;
            }

            
            yield return new WaitForSeconds(0.2f);
        }
    }
}
