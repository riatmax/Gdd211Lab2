using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void Awake()
    {
        transform.position = new Vector3(Random.Range(-20f, 20f), 25f, Random.Range(-18f, 10f));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
