using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonTest : MonoBehaviour {

    public Text m_cText;
    Button m_cButton;
	// Use this for initialization
	void Start () {
        m_cButton = this.gameObject.GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickEvent()
    {
        m_cText.text = "test";
        m_cButton.colors = ColorBlock.defaultColorBlock;
    }
}
