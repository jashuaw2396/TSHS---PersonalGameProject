using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerScript : MonoBehaviour
{
    // Setting the bullet speed & damage
    public float bulletSpeed;
    public float bulletDamage;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(DestroyMe());
	}
	
	// Update is called once per frame
	void Update ()
    {
        // We just move it forward. Nothing too fancy yet
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
	}

    IEnumerator DestroyMe()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        Debug.Log("Bullet Destroyed");
    }
}
