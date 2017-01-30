using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
    public float moveSpeed;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Move();

    }

    void Move() // Método movimiento
    {
        float xSpeed = Input.GetAxis("Horizontal");
        if (xSpeed != 0)
        {
            transform.Translate(new Vector2(xSpeed, 0) * moveSpeed * Time.deltaTime);
        }
    }

}
