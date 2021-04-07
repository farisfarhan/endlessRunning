using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < runnin.playerPosition.z - 3)
        {
            gameObject.SetActive(false);
        }
        if(runnin.collide == "y")
        {
            this.enabled = false;
        }
        if (runnin.collide == "n")
        {
            gameObject.SetActive(true);
        }
    }
}
