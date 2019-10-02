using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getSurvivors : MonoBehaviour
{
    private int playersRemaining;
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playersRemaining = GG.survivors.Count;
        // hacer funcion para obtener las vueltas
        textmeshPro.SetText("{0} left", playersRemaining);

        if (FallingTiles.gameOuva) {

            textmeshPro.enabled = false;
        }
    }
}
