using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health_points : MonoBehaviour {
    public int vidas;
    public Image deathScreen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (vidas==0 && Input.anyKeyDown)
        {
            Resume();

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb") // Si el gameobject es un ball (tag)
        {
            Destroy(other.gameObject); // Lo destruye en el tiempo establecido

            if (vidas > 0)
            {
                vidas--;
            }
            
            if (vidas == 0)
            {
                
                Pause();

            }

        }


    }

    private void Pause()
    {
        deathScreen.enabled = true;
        Time.timeScale = 0;
    }

    private void Resume()
    {
        deathScreen.enabled = false;
		SceneManager.LoadScene ("Level01", LoadSceneMode.Single);
        Time.timeScale = 1;
        Debug.Log("Reiniciado");
    }
}
