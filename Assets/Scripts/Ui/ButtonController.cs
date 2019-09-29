using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public List<GameObject> buttons;
    public int actualIndex = 0;
    private int maxIndex;
    private bool keyDown = false;
    // Start is called before the first frame update
    void Start() {
        maxIndex = buttons.Count - 1;    
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") != 0){
            if(!keyDown){
                if (Input.GetAxis("Vertical") < 0)
                {
                    if (actualIndex < maxIndex)
                    {
                        actualIndex++;
                    }else{
                        actualIndex = 0;
                    }
                }
                else if (Input.GetAxis("Vertical") > 0)
                {
                    if (actualIndex > 0)
                    {
                        actualIndex--;
                    }else{
                        actualIndex = maxIndex;
                    }
                }
                keyDown = true;
            }
        }
        else{
            keyDown = false;
        }
    }
}
