using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 startingPositon;
    
    void Start()
    {
        startingPositon = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startingPositon;
        v.z += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
