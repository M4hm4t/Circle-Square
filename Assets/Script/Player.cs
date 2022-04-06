using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> players;

    void Start()
    {
        Open();
    }
    public void Open() // make true set active beatween two objects
    {
        players.ForEach(p =>p.SetActive(false));
        int index = UnityEngine.Random.Range(0, 2);
        players[index].SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
