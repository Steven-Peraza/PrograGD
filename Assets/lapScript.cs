using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lapScript : MonoBehaviour
{
    //hacer lista de vueltas para llevar el control de cada caracter...
   public static int vueltaActual = 1;
   public static bool finalLap = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if (vueltaActual < 3){
            if (other.tag == "Player") {
                vueltaActual++;
                if (vueltaActual == 3){
                    StartCoroutine(FL());
                }
            }
        }
        else {
            Debug.Log("Se acabo la race");
        }

    }

    IEnumerator FL()
    {
        finalLap = true;
        yield return new WaitForSeconds(3);
        finalLap = false;
    }
}
