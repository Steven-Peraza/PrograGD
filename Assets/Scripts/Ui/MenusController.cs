using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusController : MonoBehaviour
{
    private GameObject main;
    private GameObject load;
    private GameObject selectPj;
    // Start is called before the first frame update
    public string sceneUi;
    private bool okChange;
    void Start()
    {
        main = GameObject.Find("Main");
        load = GameObject.Find("Load");
        selectPj = GameObject.Find("SelectPJ");
        okChange = false;
        sceneUi = "main";
    }

    // Update is called once per frame
    void Update()
    {
        if(okChange){
            switch(sceneUi){
                case "main":
                load.setActive(true);
                //Desactivar todas las demas ventanas.
                selectPj.setActive(false);
                //ventanas ...
                main.setActive(true);
                load.setActive(false);
                okChange = false;

            }   
        }
    }
}
