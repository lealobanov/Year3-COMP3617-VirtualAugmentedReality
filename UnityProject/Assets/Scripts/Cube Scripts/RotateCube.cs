using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{

public GameObject cube;
public float speed;

void Start(){
    //45 degree rotation on y-axis for static renders
    //cube.transform.Rotate(0.0f, 45.0f, 0.0f, Space.Self);
  
}
void Update() {
        // Rotate the object around its Y axis
        // Rotate 180 degrees/second, such that a full revolution is completed every 2 seconds
        transform.Rotate(Vector3.up * Time.deltaTime * speed);

    }
}
