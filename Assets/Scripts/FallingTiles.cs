using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTiles : MonoBehaviour
{

    private List<GameObject> platforms = new List<GameObject>();
    private List<int> possible = new List<int>();
    public float firstTimer = 10.0f;
    public float nextTimer = 5.0f;
    private int tileToFall, randomTile;
    public static int tilesRemaining;
    private bool moving;

    public static bool gameOuva = false;
    private bool playAura = false;
    private ParticleSystem particleObject;


    // Start is called before the first frame update
    void Start()
    {
        particleObject = GetComponentInChildren<ParticleSystem>();
        particleObject.Stop();

        for (int i = 0; i < 73; i++)
        {
            possible.Add(i);
        }

        foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("Platform")) {
            platforms.Add(fooObj);
         }
        //print(platforms.Count);
        InvokeRepeating("tileFall", firstTimer, nextTimer);
    }

    void Update() {
        if(gameOuva) {
            GG();
        }
        if (moving){
            platforms[tileToFall].transform.position += Vector3.down * 3 * Time.deltaTime;
        }
        if (playAura)
        {
            //Debug.Log("Running");
            particleObject.Play();
            playAura = false;
        }
    }

    void tileFall()
    {
        moving = false;
        tilesRemaining = possible.Count;
        randomTile = Random.Range( 0, tilesRemaining);
        tileToFall = possible[randomTile];
        particleObject.transform.position = new Vector3(platforms[tileToFall].transform.position.x, platforms[tileToFall].transform.position.y - 0.2f, platforms[tileToFall].transform.position.z);
        playAura = true;

        StartCoroutine(Example());

        possible.RemoveAt(randomTile);
        
        if (tilesRemaining == 1)
            GG();
        
    }


    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        moving = true;
    }

    void GG()
    {
        CancelInvoke();
        playAura = false;
        moving = false;
        print("Todas las plataformas cayeron, fin del juego...");
    }
}