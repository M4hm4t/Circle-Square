using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    Player player;


    [SerializeField]
    public Vector3 targetPos1;
    [SerializeField]
    public Vector3 targetPos2;
    [SerializeField]
    public float speed = 1f;
    public bool canMove;
    public bool firstMove;
    void Start()
    {
        player = GetComponent<Player>();

        //firstMove = true;

    }
    void Update()
    {
       /* if (transform.position == targetPos1)
        {
            player.Open();
            firstMove = false;
        }
        if (transform.position == targetPos2)
        {
            player.Open();

            firstMove = true;
        }*/
        if (canMove)
        {
            if (firstMove)
            {
                //  transform.position = Vector3.MoveTowards(transform.position, targetPos1, speed * Time.deltaTime);
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else
            {
                //  transform.position = Vector3.MoveTowards(transform.position, targetPos2, speed * Time.deltaTime);

                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canMove)
        player.Open();
        firstMove = !firstMove;
        Debug.Log("Kontrol");
    }
}