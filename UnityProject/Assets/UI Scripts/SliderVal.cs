using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderVal: MonoBehaviour {
  public Slider sliderUI;
  private Text textSliderValue;
  public Material material;

  void Start (){
    textSliderValue = GetComponent<Text>();

    string sliderMessage = ""+sliderUI.value;
    this.material.SetFloat( "_Const", sliderUI.value );
    textSliderValue.text = sliderMessage;
  }

  void Update(){
      textSliderValue = GetComponent<Text>();
      string sliderMessage = ""+sliderUI.value;
      this.material.SetFloat( "_Const", sliderUI.value );
      textSliderValue.text = sliderMessage;
 
  }

 
}