using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_generator : MonoBehaviour {
    public GameObject bomba;
    public GameObject bombaClon;
    public int minPos=-3;
    public float maxPos = 3;
    Vector3 spawnPoint;
    public int max = 15;
    public float bombdelay=0.5F;
    


    // Use this for initialization
    void Start () {
        StartCoroutine(spawn());

    }
	
	// Update is called once per frame
	void Update () {
       


    }

    IEnumerator spawn()
    {
        for (int i =0; i<max; i++)
        {
            spawnPoint = new Vector3(Random.Range(minPos, maxPos), 6, 0);
            bombaClon = Instantiate(bomba, spawnPoint, transform.rotation);
            Debug.Log(i);
            yield return new WaitForSeconds(bombdelay);
           
        }
        
    }


}
