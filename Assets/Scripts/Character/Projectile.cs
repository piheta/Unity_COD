using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class Projectile : MonoBehaviour {

	[Range(5, 100)]
	public float minDestroyTime;
	public float maxDestroyTime;

	public bool destroyOnImpact = false;


	[Header("Impact Effect Prefabs")]
	public Transform [] metalImpactPrefabs;

	private float damage = 30f;

	private void Start ()
	{
		
	}

	//If the bullet collides with anything
	private void OnCollisionEnter(Collision collision)
	{
		//Ignore collisions with other projectiles.
		if (collision.gameObject.GetComponent<Projectile>() != null)
			return;


		//If destroy on impact is false, start 
		//coroutine with random destroy timer
		if (!destroyOnImpact)
		{
			StartCoroutine(DestroyTimer());
		}
		//Otherwise, destroy bullet on impact
		else
		{
			Destroy(gameObject);
		}


		//If bullet collides with "Metal" tag
		if (collision.transform.tag == "Metal") 
		{
			collision.collider.GetComponent<EnemyManager>().Hit(damage);

			//Instantiate random impact prefab from array
			Instantiate (metalImpactPrefabs [Random.Range 
				(0, metalImpactPrefabs.Length)], transform.position, 
				Quaternion.LookRotation (collision.contacts [0].normal));
			//Destroy bullet object
			Destroy(gameObject);
		}
	}

	private IEnumerator DestroyTimer()
	{
		//Wait random time based on min and max values
		yield return new WaitForSeconds
			(Random.Range(minDestroyTime, maxDestroyTime));
		//Destroy bullet object
		Destroy(gameObject);
	}

}