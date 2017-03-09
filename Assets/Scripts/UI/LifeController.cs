using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{

    [SerializeField]
    private GameObject _heartPrefab;

    [SerializeField]
    private int _numHearts;

    [SerializeField]
    private GridController _gridController;

    private List<HeartController> _hearts = new List<HeartController>();

    private HeartController _currentHeart;

    

    private void Awake()
    {
    
    }

    public HeartController AddNewHeart()
    {
        var newObject = Instantiate<GameObject>(_heartPrefab);
        newObject.transform.SetParent(transform);
        newObject.transform.localPosition = Vector3.zero;
        _gridController.AddObject(newObject);
        var heartController = newObject.GetComponent<HeartController>();
        _hearts.Add(heartController);

        if(_currentHeart != null)
        {
            _currentHeart.SetPulsing(false);
        }
        _currentHeart = heartController;
        _currentHeart.SetPulsing(true);
        return heartController;
    }

    public void RemoveHeartSegments(int segments)
    {

        for(int i = _hearts.Count - 1; i >= 0 && segments > 0; i--)
        {
            var heart = _hearts[i];
            var heartSegments = heart.GetCurrentState;
            heart.TakeDamage(segments);
            segments -= heartSegments;
        }   
    }

    // Use this for initialization
    void Start ()
    {
		for(int i = 0; i < _numHearts; i++)
        {
            AddNewHeart();
        }
        if(_currentHeart != null)
        {
            _currentHeart.SetPulsing(true);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
