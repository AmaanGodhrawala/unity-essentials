using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomX : MonoBehaviour
{
    void Start()
    {
        float randomX = Random.Range(-8f, 8f);
        
        transform.position = new Vector3(randomX, 12f, transform.position.z);
    }
    void Update()
    {
        
    }
}
