using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG : MonoBehaviour
{
    // hacer la lista de los players
    GameObject player;
    GameObject limite;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        limite = GameObject.FindGameObjectWithTag("Finish");
    }

    // Update is called once per frame
    void Update()
    {
        //meter esto en un for checando por cada "player"
        if (player.transform.position.y <= limite.transform.position.y)
        {
            print("Te mamaste...");
        }
    }
}
