using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotoate : MonoBehaviour
{
    [SerializeField] private float accelx = 10;

    void Update()
    {
         transform.Rotate (-(accelx * Time.deltaTime), 0, 0);

    }
 
}
