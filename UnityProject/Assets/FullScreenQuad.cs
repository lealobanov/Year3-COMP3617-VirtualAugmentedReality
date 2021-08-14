using UnityEngine;

[ExecuteInEditMode]
public class FullScreenQuad : MonoBehaviour
{
    // A Material with the Unity shader you want to process the image with
    public Material mat;

    void Start(){
         Debug.Log("Hello");
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        // Read pixels from the source RenderTexture, apply the material, copy the updated results to the destination RenderTexture
        Graphics.Blit(src, dest, mat);
    }
}

