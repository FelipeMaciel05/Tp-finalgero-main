using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulo : MonoBehaviour
{
    float nashei = 300f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(nashei * Time.deltaTime, 0, 0);
    }
}
