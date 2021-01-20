using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAlSol : MonoBehaviour
{

    public GameObject sun;
    public GameObject planet;
    public int velocidad;
    public int angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(sun.transform.position, planet.transform.position, angle);
        transform.RotateAround(sun.transform.position, Vector3.up, velocidad * Time.deltaTime);



    }
}
                
