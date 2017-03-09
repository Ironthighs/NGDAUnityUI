using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    private int _totalRupees;

    public void AddRupees(int numRupees)
    {
        _totalRupees += numRupees;
        MainGameHUD.Instance.SetRupeeCount(_totalRupees.ToString());
    }

	// Use this for initialization
	void Start ()
    {
        MainGameHUD.Instance.SetRupeeCount(_totalRupees.ToString());
	}
	
}
