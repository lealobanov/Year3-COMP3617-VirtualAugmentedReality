using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownFunction : MonoBehaviour
{
    public GameObject mesh1;
    public GameObject mesh2;
    public GameObject mesh3;
    public GameObject mesh4;
    public GameObject mesh5;
    public GameObject mesh6;
    public GameObject mesh7;
    public GameObject mesh8;
    public GameObject mesh9;
    public GameObject mesh10;
    public GameObject mesh11;


    public void Start(){
        mesh1.SetActive(true);

    }
    public void DropDownFunctioning(int value){

        if(value == 0){
            mesh1.SetActive(true);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
         

        }

         if(value == 1){
            mesh1.SetActive(false);
            mesh2.SetActive(true);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

         if(value == 2){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(true);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

         if(value == 3){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(true);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

         if(value == 4){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(true);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

         if(value == 5){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(true);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

         if(value == 6){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(true);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

        if(value == 7){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(true);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

        if(value == 8){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(true);
            mesh10.SetActive(false);
            mesh11.SetActive(false);
        }

         if(value == 9){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(true);
            mesh11.SetActive(false);
        }

         if(value == 10){
            mesh1.SetActive(false);
            mesh2.SetActive(false);
            mesh3.SetActive(false);
            mesh4.SetActive(false);
            mesh5.SetActive(false);
            mesh6.SetActive(false);
            mesh7.SetActive(false);
            mesh8.SetActive(false);
            mesh9.SetActive(false);
            mesh10.SetActive(false);
            mesh11.SetActive(true);
        }








        
    }
}
