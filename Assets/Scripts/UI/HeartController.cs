using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartController : MonoBehaviour
{

    [SerializeField]
    private Image _heartFill;

    [SerializeField]
    private int _numHeartStates;

    [SerializeField]
    private float _pulseSpeed;
    [SerializeField]
    private float _pulseSize;

    private int _currentState;

    private bool _isPulsing = false;
    private float degrees = 0;

    public int GetCurrentState
    {
        get { return _currentState; }
    }

    public void TakeDamage(int damage)
    {
        _currentState = Mathf.Clamp(_currentState - damage, 0, _numHeartStates);
        _heartFill.fillAmount = (float)_currentState / (float)_numHeartStates;
    }

    public void SetPulsing(bool isPulsing)
    {
        _isPulsing = isPulsing;
        transform.localScale = Vector3.one;
    }

    private void Start ()
    {
        _currentState = _numHeartStates;
    }

    private void Update ()
    {
        if(!_isPulsing)
        {
            return;
        }
        var scaleMath = _pulseSize * Mathf.Cos(_pulseSpeed * degrees);
        var scaleX = transform.localScale.x + scaleMath;
        var scaleY = transform.localScale.y + scaleMath;
        iTween.ScaleUpdate(gameObject, iTween.Hash("x", scaleX, "y", scaleY));
        degrees += Time.deltaTime;
        degrees = degrees % 359;
	}
}
