using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPanel(){

        if (panel != null){

             if(panel.activeSelf){
                 panel.SetActive(false);
             }
            else{
            panel.SetActive(true);
            }
        }

    }
}
