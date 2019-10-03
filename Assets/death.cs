using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public static bool F;
    //public Vector3 position;
    private GameObject GO,P;

    // Start is called before the first frame update
    void Start()
    {
        GO = GameObject.FindGameObjectWithTag("Respawn");
        P = GameObject.FindGameObjectWithTag("Player");
        F = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (F){
            Destroy(P);
            F = false;
        }
    }
}
