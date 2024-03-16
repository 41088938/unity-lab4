using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Myscrit : MonoBehaviour
{
    GameObject sun; 
    GameObject[] mylights;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //sun = GameObject.Find("Directional Light");
        sun = GameObject.FindWithTag("sunlight");


            mylights = GameObject.FindGameObjectsWithTag("scenelight");
            foreach (GameObject mylight in mylights)
            {
                mylight.GetComponent<Light>().color = Color.red;
            }

            player = GameObject.FindWithTag("Player");
            player.GetComponent<FirstPersonController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0.1f, 0);
        //transform.Translate(0, 0, 1 * Time.deltaTime);
        //transform.Rotate(Vector3.up * 60 * Time.deltaTime);
        transform.position = new Vector3(5, 1, 10);

        sun.transform.Rotate(Vector3.left * 30 * Time.deltaTime);
    }
}
