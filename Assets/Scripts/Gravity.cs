using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] Ball attractplanet;
    Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        Player = transform;
    }

    private void FixedUpdate()
    {
        if(attractplanet)
        {
            attractplanet.Attract(Player);
        }
    }
}
