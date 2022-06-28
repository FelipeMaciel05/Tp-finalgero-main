using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Tren")
        {
            SceneManager.LoadScene("Escena 2");
            transform.position = new Vector3(99, 0.5f, 0);
        }
        if (col.gameObject.tag == "Perdes")
        {
            SceneManager.LoadScene("Escena 3");
            transform.position = new Vector3(99, 0.5f, 0);
        }
    }
    public void Jugar()
    {
        SceneManager.LoadScene("Escena 1");
    }

    public void Tucson()
    {
        SceneManager.LoadScene("Controles");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel 2");
    }
    public void MenuNiveles()
    {
        SceneManager.LoadScene("MenuNiveles");
    }
}
