using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "End Zone")
        {
            other.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
