using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    private float _lastHit;
    private float _cooldown = 2;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && _lastHit + _cooldown < Time.time)
        {
            _lastHit = Time.time;
            MainGameHUD.Instance.TakeDamage(Random.Range(1, 6));
        }
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
