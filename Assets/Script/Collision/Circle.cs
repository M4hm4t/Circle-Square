using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
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
        if (collision.gameObject.tag.Equals("Circle"))
        {

            Debug.Log("Circle");
            FindObjectOfType<GameManager>().AddScore();
        }
        if (collision.gameObject.tag.Equals("Square"))
        {

            FindObjectOfType<CameraShake>().ShakeIt();
            Debug.Log("FAÝL");
        }
    }



}
