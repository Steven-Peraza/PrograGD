using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class getTiles : MonoBehaviour
{
    private int tilesActual;
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tilesActual = FallingTiles.tilesRemaining;
        // hacer funcion para obtener las vueltas
        textmeshPro.SetText("{0} left", tilesActual);

        if (FallingTiles.gameOuva) {

            textmeshPro.enabled = false;
        }
    }
}
