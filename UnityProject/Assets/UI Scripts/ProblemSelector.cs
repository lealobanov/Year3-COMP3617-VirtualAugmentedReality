using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class ProblemSelector : MonoBehaviour
{

   
    public void DropDownFunctioning(int value){

        if(value == 0){
           //Pass - placeholder value
        }

         if(value == 1){
           //Problem 1
           SceneManager.LoadScene (sceneName:"Problem 1");
        }

         if(value == 2){
           //Problem 2
           SceneManager.LoadScene (sceneName:"Problem 2");
        }

         if(value == 3){
           //Problem 3
           SceneManager.LoadScene (sceneName:"Problem 3");
        }

         







        
    }
}
