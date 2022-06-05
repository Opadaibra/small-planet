using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float gravity = -12    ;
    public void Attract (Transform playertransform)
    {
        Vector3 gravityUp = (playertransform.position - transform.position).normalized;
        Vector3 localup = playertransform.up;
        playertransform.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetrotaion = Quaternion.FromToRotation(localup, gravityUp) * playertransform.rotation;
        playertransform.rotation = Quaternion.Slerp(playertransform.rotation, targetrotaion, 10f * Time.deltaTime);
    }
}
