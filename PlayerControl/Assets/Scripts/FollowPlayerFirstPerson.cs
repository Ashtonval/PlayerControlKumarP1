using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerFirstPerson : MonoBehaviour
{
    public GameObject FirstPerson;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            FirstPerson.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FirstPerson.SetActive(false);
        }
    }
}
