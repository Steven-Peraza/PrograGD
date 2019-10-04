using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public int thisIndex;
    private Animator anim;
    [SerializeField] ButtonController buttonController;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonController.actualIndex == thisIndex){
            anim.SetBool("hover", true);
            if(Input.GetAxis("Submit") == 1){
                anim.SetBool("press", true);
                
            }
            else if(anim.GetBool("press")){
                
            }
        }else{
            anim.SetBool("hover", false);
        }
    }
}
