using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBillboard : MonoBehaviour
{
    private GameObject _player;
	// Use this for initialization
	void Start ()
    {
        _player = GameObject.FindGameObjectsWithTag("MainCamera")[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(_player.transform);
	}
}
