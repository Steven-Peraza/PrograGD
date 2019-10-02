using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class getLapScript : MonoBehaviour
{
    private int actualLap;
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        actualLap = lapScript.vueltaActual;
        // hacer funcion para obtener las vueltas
        textmeshPro.SetText("{0} / 3", actualLap);
    }
}
