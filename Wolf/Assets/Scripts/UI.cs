using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class UI : MonoBehaviour {
    
    private Button Button_up;
    
    private Button Button_left;
    private Button Button_right;

	
	void Start () {
    
        Button_up = GameObject.Find("Button_up").GetComponent<Button>();
        Button_left = GameObject.Find("Button_right").GetComponent<Button>();
        Button_right = GameObject.Find("Button_right").GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {


   }

}
