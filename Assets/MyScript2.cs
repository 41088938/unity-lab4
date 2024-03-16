using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myscrit2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0.1f, 0);
        //transform.Translate(0, 0, 1 * Time.deltaTime);
        transform.Rotate(Vector3.up * 60 * Time.deltaTime, Space.World );
        transform.localPosition = new Vector3(5, 0, 00);
        transform.localScale += new Vector3(0, 0, 1.1f * Time.deltaTime) ;

        
    }
}