using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GG : MonoBehaviour
{
    // hacer la lista de los players
    private GameObject[] players;
    public static List<GameObject> survivors, fallen;
    GameObject limite;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        limite = GameObject.FindGameObjectWithTag("Finish");

        survivors = players.ToList();
        fallen = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject murido in survivors)
        {
            if (murido.transform.position.y <= limite.transform.position.y)
            {
                print("Player Defeated!");
                fallen.Add(murido);
            }
        }
        foreach (GameObject F in fallen)
        {
            survivors.Remove(F);
            Destroy(F);
        }
 

        if (survivors.Count == 1){
            //ver lo del GameOver
            print("Juego Terminado!");
            FallingTiles.gameOuva = true;
        }
    }
}
