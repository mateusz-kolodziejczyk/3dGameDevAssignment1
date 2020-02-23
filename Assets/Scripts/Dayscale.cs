using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dayscale : MonoBehaviour
{
    [Tooltip("number of minutes per second")]
    public float minutesPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
        float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
        transform.RotateAround(transform.position, Vector3.right, angleThisFrame);
    }
}
