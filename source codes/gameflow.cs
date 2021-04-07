using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public Transform tile1Obj;
    private Vector3 nextTileSpawn;

    public Transform bNinjaObj;
    private Vector3 nextbNinjaSpawn;
    public Transform mineObj;
    private Vector3 nextMineSpawn;
    private int randX;

    // Start is called before the first frame update
    void Start()
    {
        nextTileSpawn.z = 30;
        StartCoroutine(spawnTile());
    }

    // Update is called once per frame
    void Update()
    {
        if (runnin.collide == "y")
        {
            StopAllCoroutines();
        }

    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);

        randX = Random.Range(-1, 2);
        nextbNinjaSpawn = nextTileSpawn;
        nextbNinjaSpawn.x = randX;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(bNinjaObj, nextbNinjaSpawn, bNinjaObj.rotation);
        nextTileSpawn.z += 5;

        randX = Random.Range(-1, 2);
        nextMineSpawn = nextTileSpawn;
        nextMineSpawn.x = randX;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(mineObj, nextMineSpawn, mineObj.rotation);
        nextTileSpawn.z += 5;

        StartCoroutine(spawnTile());

       
    }
}
