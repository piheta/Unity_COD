using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{


    public Animator enemyAnimator;
    public float damage = 20f;
    public float health = 100;
    public GameManager gameManager;
    public GameObject loot1;
    public GameObject loot2;


    NavMeshAgent nm;
    public Transform target;
    public enum AIState { idle, chasing, attack };
    public AIState aiState = AIState.idle;
    public float distanceTreshold = 10f;
    public float attackThreshold = 0.5f;
    public System.Random rnd = new System.Random();
    public int whichLoot;


    public AudioSource audioSource;
    public AudioClip[] zombieSounds;

    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        StartCoroutine(Think());
        audioSource = GetComponent<AudioSource>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() 
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = zombieSounds[Random.Range(0, zombieSounds.Length)];
            audioSource.Play();
        }


    }


    public void Hit(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            money.player_money += 50;
            GenerateObject(gameObject);
            enemyAnimator.SetTrigger("dead");
            gameManager.enemiesAlive--;
            Destroy(gameObject, 5f);
            Destroy(GetComponent<NavMeshAgent>());
            Destroy(GetComponent<EnemyManager>());
            Destroy(GetComponent<CapsuleCollider>());
            

        }
    }

    void GenerateObject(GameObject zombie)
    {
        System.Random rnd = new System.Random();
        Vector3 zomPos = zombie.transform.position;

        //create a number between 1 and 20, get loot if number is 1, 5%
        int ifLoot = rnd.Next(1,21);
        if(ifLoot == 1){

            // creates a number between 1 and 2 and pick which loot to drop
            int whichLoot  = rnd.Next(1, 3);
            if(whichLoot == 1){
                Instantiate(loot1, zomPos, zombie.transform.rotation);
            } else {
                Instantiate(loot2, zomPos, zombie.transform.rotation);
            }
        }
    }


    IEnumerator Think()
    {
        while (true)
        {
            switch (aiState)
            {
                case AIState.idle:
                    float dist = Vector3.Distance(target.position, transform.position);
                    if (dist < distanceTreshold)
                    {
                        aiState = AIState.chasing;
                        enemyAnimator.SetBool("Chasing", true);
                    }
                    nm.SetDestination(transform.position);
                    break;
                case AIState.chasing:
                    dist = Vector3.Distance(target.position, transform.position);
                    if (dist > distanceTreshold)
                    {
                        aiState = AIState.idle;
                        enemyAnimator.SetBool("Chasing", false);
                    }

                    if (dist < attackThreshold)
                    {
                        aiState = AIState.attack;
                        enemyAnimator.SetBool("Attacking", true);
                        target.GetComponent<PlayerManager>().Hit(damage);
                    }
                    nm.SetDestination(target.position);
                    break;
                case AIState.attack:
                    Debug.Log("Attack");
                    nm.SetDestination(transform.position);
                    dist = Vector3.Distance(target.position, transform.position);
                    if (dist > attackThreshold)
                    {
                        aiState = AIState.chasing;
                        enemyAnimator.SetBool("Attacking", false);
                    }
                    break;
                default:
                    break;
            }


            yield return new WaitForSeconds(0.2f);
        }
    }
}
