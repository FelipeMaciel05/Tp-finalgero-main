using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Movimiento : MonoBehaviour
{
    public float subida;
    float a;
    float speed = -7f;
    int derecha = 1;
    int izquierda = 1;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.D) && derecha <= 1 && derecha>=0)
        {
            transform.Translate(0, 0, 2);
            derecha += 1;
            izquierda -= 1;
        }
        if (Input.GetKeyDown(KeyCode.A) && izquierda <= 1 && izquierda>=0)
        {
            transform.Translate(0, 0, -2);
            izquierda += 1;
            derecha -= 1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(1, 0.5f, 1);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if(a < 0.60f)
            {
                rb.AddForce(Vector3.up * subida, ForceMode.Impulse);
            }
        }
        a = transform.position.y;
    }


    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Velocidad")
        {
            speed -= 1.5f;
        }
    }
}
