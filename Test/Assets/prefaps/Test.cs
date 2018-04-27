using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//C#에서 구조체는 기본접근자가 private이다.
struct STest
{
    //각각 멤버마다 접근지정자를 직접 지정해야한다.
    //생략하면 private
    public int nData;
}

public class Test : MonoBehaviour
{
    public int nIdx; //인스팩터 창에 노출을 시키려면, public멤버로 만든다.
    int nTest;
    Rigidbody m_cRigidBody;//컴포넌트는 객체로 취급된다.
    Test m_cTest; //클래스는 구조체가 아닌 포인터로 취급된다.
    STest m_sTest; //구조체는 객체가 생성된다.
    Vector3 m_vPos;

    private void Awake()
    {
        Debug.Log("Test.Awake:" + gameObject.activeSelf);
        this.gameObject.SetActive(true);
    }

    // Use this for initialization
    void Start()
    {
        Debug.Log("Test.Start:" + gameObject.activeSelf);
        //해당 오브젝트에 GetCompoent()함수로 컴포넌트를 가져올수있다.
        //m_cRigidBody = this.GetComponent<Rigidbody>();
        //m_cRigidBody.useGravity = false;
        //m_cTest = this; //자기자신의 객체의 값을 참조하게된다.
        m_cTest.nIdx = 2;
        m_sTest.nData = 10;

        //컴포넌트는 자기를 가지고있는 게임오브젝트를 알수있다.
        Debug.Log(m_cTest.gameObject.name);

        //m_vPos = new Vector3(0, 0, 0); //구조체에 new를 할때는 동적할당하는것이아니라 생성자를 호출하는것!
        m_vPos.x = 10;

        Debug.Log("" + m_vPos);
    }

    // Update is called once per frame
    void Update()
    {
        if (nIdx == 0) //0번이 부모임으로 부모일때만 회전을 적용시킨다.
            this.transform.Rotate(0, 1, 0);
    }

    private void OnGUI()
    {
        //오브젝트의 행렬을 가져온다.
        Matrix4x4 mat = this.transform.localToWorldMatrix;
        //자식과 부모의 UI가 겹치는 현상을 막기위해 높이를 변경함.
        GUI.Box(new Rect(0, 80 * nIdx, 250, 80), "" + mat);
    }
}
