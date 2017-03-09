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

    private void Awake()
    {
        _instance = this;
    }

    public void TakeDamage(int heartSegments)
    {
        _lifeController.RemoveHeartSegments(heartSegments);
    }

    public void SetRupeeCount(string rupeeCount)
    {
        _rupeeCount.text = rupeeCount;
    }
}
