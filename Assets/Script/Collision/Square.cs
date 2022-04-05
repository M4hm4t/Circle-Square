using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
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
        if (collision.gameObject.tag.Equals("Square"))
        {
            Debug.Log("Square");
            FindObjectOfType<GameManager>().AddScore();
        }
        if (collision.gameObject.tag.Equals("Circle"))
        {

            FindObjectOfType<CameraShake>().ShakeIt();
            Debug.Log("FAÝL");
        }
    }



}
