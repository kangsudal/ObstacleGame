using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        hits++;
        Debug.Log("you've bumped into a thing in this many times: "+hits);
    }
}
