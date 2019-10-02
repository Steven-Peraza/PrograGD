using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class canvastextP : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FallingTiles.gameOuva) {

            textmeshPro.enabled = false;
        }
    }
}
