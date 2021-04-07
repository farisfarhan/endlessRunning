using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninjaRun : MonoBehaviour
{
    //private Animator animNinja;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -0.5f);
        //animNinja.SetBool("isGameLost", false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //animNinja.SetBool("isGameLost", runnin.anim.GetBool("isGameLost"));
        //if(runnin.collide == "y")
       // {
        //    this.enabled = false;
        //}
    }
}
