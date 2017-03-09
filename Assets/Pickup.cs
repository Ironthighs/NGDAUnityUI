using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField]
    private int _rupeeValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lonk")
        {
            var player = other.gameObject.GetComponent<MyPlayer>();
            player.AddRupees(_rupeeValue);
            Destroy(gameObject);
        }
    }

}
