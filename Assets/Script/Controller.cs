using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

   public Vector3 position= new Vector3(0.6f,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            position = position * -1; ;
            transform.position = position;
        }

       /* if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            transform.position = new Vector3(0.6f,0,0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            transform.position = new Vector3(-0.6f,0,0);
        }*/
    }
}
