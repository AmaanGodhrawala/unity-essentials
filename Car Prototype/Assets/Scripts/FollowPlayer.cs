// using System.Numerics;
// using System.Threading.Tasks.Dataflow;
// using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public UnityEngine.Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position= player.transform.position + offset;
        
    }
}
