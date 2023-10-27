using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(30*Time.deltaTime, 15 * Time.deltaTime, 45 * Time.deltaTime);
    }
}
