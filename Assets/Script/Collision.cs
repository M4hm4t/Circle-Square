using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    GameManager gameManager;
    CameraShake cameraShake;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.tag.Equals(gameObject.tag))
        {
            FindObjectOfType<GameManager>().AddScore();
        }
        else
        {
            
           FindObjectOfType<GameManager>().ResetScore();
            FindObjectOfType<CameraShake>().ShakeIt();

        }
    }



}
