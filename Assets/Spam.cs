using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spam : MonoBehaviour
{
    public GameObject prefab;
    GameObject clon;
    public GameObject mensaje;
    public GameObject mensajeGanar;
    bool Choque;
    int cuenta;
    // Start is called before the first frame update
    void Start()
    {
        Choque = false;
        cuenta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Choque == true && cuenta < 25)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < 3; i++)
                {
                    clon = Instantiate(prefab);
                    clon.transform.position = transform.position - new Vector3(0.5f, 0.2f, 0.2f);
                    Destroy(clon, 1);
                }
                cuenta += 1;
            }
        }
        if(cuenta == 25)
        {
            transform.position = new Vector3(-88, 0.5f, 0);
            mensaje.SetActive(false);
            mensajeGanar.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Spam")
        {
            Choque = true;
            mensaje.SetActive(true);
        }
    }
}
