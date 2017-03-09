using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameHUD : MonoBehaviour
{
    private static MainGameHUD _instance;

    public static MainGameHUD Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new GameObject("MainGameHUD").AddComponent<MainGameHUD>();
            }
            return _instance;
        }
    }


    [SerializeField]
    private LifeController _lifeController;

    [SerializeField]
    private Text _rupeeCount;

    public void TakeDamage(int heartSegments)
    {
        _lifeController.RemoveHeartSegments(heartSegments);
    }

    public void SetRupeeCount(string rupeeCount)
    {
        _rupeeCount.text = rupeeCount;
    }

	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 150, 80), "Add Heart"))
        {
            TakeDamage(3);

        }
    }
}
