using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarksCount : MonoBehaviour
{
    [SerializeField] private float[] marks;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddMark(int mark)
    {
        print(marks[mark-1]);
    }
}
