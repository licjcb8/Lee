using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Basic : MonoBehaviour {
    StructA m_sStruct;
    ClassA m_cClass;
	// Use this for initialization
	void Start () {
        this.transform.position = new Vector3(0,0,0);
        m_sStruct = new StructA(100);
        //m_sStruct.Data = 10;
        Debug.Log("StructData" + m_sStruct.Data);
        m_cClass = new ClassA(100);
        //m_cClass.Data = 20;
        Debug.Log("ClassData" + m_cClass.Data);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
