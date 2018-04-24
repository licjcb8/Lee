using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct StructA
{
    int m_nData;
    public StructA(int data)
    {
        m_nData = data;
    }
    //void SetData(int data)
    //{
    //    m_nData = data;
    //}
    public int Data
    {
        get { return m_nData; }
        set { m_nData = value; }
    }
}

public class ClassA
{
    int m_nData;
    public ClassA(int data)
    {
        m_nData = data;
    }

    public int Data
    {
        get { return m_nData; }
        set { m_nData = value; }
    }
}

