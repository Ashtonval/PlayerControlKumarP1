using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomingTraffic : MonoBehaviour
{
    public float speed = -20;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
