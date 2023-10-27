using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    [SerializeField] GameObject[] movingPointsTargets;
    int curMP_TargetIndex = 0; // current moving points target index


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, movingPointsTargets[curMP_TargetIndex].transform.position) < 0.1f)
        {
            curMP_TargetIndex++;

            if (curMP_TargetIndex == movingPointsTargets.Length)
            {
                curMP_TargetIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, movingPointsTargets[curMP_TargetIndex].transform.position, 6.5f * Time.deltaTime);
    }
}