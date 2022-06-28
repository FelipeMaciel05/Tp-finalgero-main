using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tiempo : MonoBehaviour
{
    public Text txttime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txttime.text = Mathf.FloorToInt(Time.time).ToString();
    }

}


