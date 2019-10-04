using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectCharacterController : MonoBehaviour
{
    public List<GameObject> pjs;
    private GameObject pj;

    private GameObject showPj;
    public List<GameObject> rows;
    public int actualIndex = 0;
    private int maxIndex;
    private bool keyDown = false;
    // Start is called before the first frame update
    void Start()
    {
        maxIndex = pjs.Count - 1;
        showPj = GameObject.Find("PJ");
        pj = Instantiate(pjs[actualIndex], showPj.transform);
        pj.GetComponent<CharacterController>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (!keyDown)
            {
                keyDown = true;
                if (Input.GetAxis("Horizontal") > 0)
                {
                    if (actualIndex < maxIndex)
                    {
                        actualIndex++;
                    }
                    else
                    {
                        actualIndex = 0;
                    }
                    rows[0].GetComponent<Animator>().SetBool("press", keyDown);
                }
                else if (Input.GetAxis("Horizontal") < 0)
                {
                    if (actualIndex > 0)
                    {
                        actualIndex--;
                    }
                    else
                    {
                        actualIndex = maxIndex;
                    }
                    rows[1].GetComponent<Animator>().SetBool("press", keyDown);
                }
                changeCharacter();
            }
        }
        else
        {
            keyDown = false;
            rows[0].GetComponent<Animator>().SetBool("press", keyDown);
            rows[1].GetComponent<Animator>().SetBool("press", keyDown);
        }
    }

    void changeCharacter() {
        GameObject.Destroy(pj);
        pj = Instantiate(pjs[actualIndex], showPj.transform);
    }
}
