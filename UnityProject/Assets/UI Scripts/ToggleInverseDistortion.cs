using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleInverseDistortion : MonoBehaviour
{
    public Toggle toggle;
     public Material material;

    // Start is called before the first frame update
    void Start()
    {
         this.material.SetFloat( "_Invert", 0 );  
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle.isOn) {
            this.material.SetFloat( "_Invert", 1 );
        }
        else{
            this.material.SetFloat( "_Invert", 0 );
        }
    }
}
