using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Basic : MonoBehaviour {
    StructA m_sStruct;
    ClassA m_cClass;
    List<ClassA> m_listClassA;
    LinkedList<ClassA> m_linkedlistClassA;
    Dictionary<string,ClassA> m_dicClassA;
	// Use this for initialization
	void Start () {
        this.transform.position = new Vector3(0,0,0);
        m_sStruct = new StructA(100);
        //m_sStruct.Data = 10;
        SetDataStruct(m_sStruct, 20);
        Debug.Log("StructData" + m_sStruct.Data);
        m_cClass = new ClassA(100);
        //m_cClass.Data = 20;
        SetDataClass(m_cClass, 10);
        Debug.Log("ClassData" + m_cClass.Data);
        string addPlus = "A" +"d" + "d";
        string addFormat = string.Format("{0}{1}{2}", "A", "d", "d");
        Debug.Log(string.Format("{0}/{1}", addPlus, addFormat));
    }


    void SetDataStruct(StructA s, int data)
    {
        s.Data = data;
    }


    void SetDataClass(ClassA c, int data)
    {
        c.Data = data;
    }

}
