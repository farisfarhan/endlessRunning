using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class runnin : MonoBehaviour
{
    private string laneChange = "n";
    private string jump = "n";
    public static Vector3 playerPosition;
    public static string collide = "n";
    public static int score = 0;
    public static int lastScore = 0;
    public GameObject bg;

    public static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Animator>().Play("Quick Roll To Run");
        anim = GetComponent<Animator>();
        anim.SetBool("laneChanging", false);
        anim.SetBool("isGameLost", false);
        anim.SetBool("isJumping", false);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        StartCoroutine(countScore());
    }

    // Update is called once per frame
    void Update()
    {
        if (runnin.collide == "y")
        {
            score = 0;
            StartCoroutine(countScore());
            
        }

        playerPosition = transform.position;
        if (Input.GetKey("a") && laneChange == "n" && transform.position.x > -.9 && jump == "n")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 5);
            laneChange = "y";
            anim.SetBool("laneChanging", true);
            StartCoroutine(stopLaneCh());
        }
        if (Input.GetKey("d") && laneChange == "n" && transform.position.x < .9 && jump=="n")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 5);
            laneChange = "y";
            anim.SetBool("laneChanging", true);
            StartCoroutine(stopLaneCh());
        }
        if (Input.GetKey("space") && jump =="n" && laneChange == "n" )
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 1.5f, 5);
            jump = "y";
            anim.SetBool("isJumping", true);
            StartCoroutine(stopJump());
        }
      
    }
    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(.5f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, -1.5f, 5);
        yield return new WaitForSeconds(.5f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);

        jump = "n";
        anim.SetBool("isJumping", false);

    }

    IEnumerator stopLaneCh()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        anim.SetBool("laneChanging", false);
        laneChange = "n";

        //Debug.Log(GetComponent<Transform>().position);
    }

    IEnumerator countScore()
    {
        yield return new WaitForSeconds(0.2f);
        score += 10;
        StartCoroutine(countScore());
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
            //Debug.Log("OUCH!");
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            lastScore = score;
            collide = "y";
            anim.SetBool("isGameLost", true);
            bg.SetActive(true);
            StopAllCoroutines();
            

        }
    }
}
