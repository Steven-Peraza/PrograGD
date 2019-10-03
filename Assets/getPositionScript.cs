using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class getPositionScript : MonoBehaviour
{
    private int actualPosition;
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        actualPosition = 4;
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        // hacer funcion para obtener las vueltas
        textmeshPro.SetText("{0} / 4", actualPosition);
    }
}
