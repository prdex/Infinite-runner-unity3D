using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

    public GameObject[] tilemanager;

    private Transform playertransform;
    private float spawnZ = -50.0f;
    private float length = 100.0f;
    private int amountoftile = 7;
    private float safezone = 150.0f;

    private List<GameObject> activetiles;

	private void Start () {
        activetiles = new List<GameObject>();
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;	

        for(int i = 0; i < amountoftile; i++)
        {
            spawntile();
        }
	}
	
	
	private void Update () {
		if(playertransform.position.z - safezone > (spawnZ - amountoftile * length)){
            spawntile();
            deletetile();
        }
	}

    private void spawntile(int prefabindex = -1)
    {
        GameObject handle;
        handle = Instantiate(tilemanager[0]) as GameObject;
        handle.transform.SetParent(transform);
        handle.transform.position = Vector3.forward * spawnZ;
        spawnZ = spawnZ + length;
        activetiles.Add(handle);
    }
    private void deletetile()
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);
    }
}
