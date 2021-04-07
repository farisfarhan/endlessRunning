using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammove : MonoBehaviour
{   
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5 );
        
    }

    // Update is called once per frame
    void Update()
    {
        if (runnin.collide == "y")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        else if (runnin.collide == "n")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }
    }

    IEnumerator checkSuitableSpeed()
    {
        yield return new WaitForSeconds(0.2f);
        

        //StartCoroutine();
    }
}
