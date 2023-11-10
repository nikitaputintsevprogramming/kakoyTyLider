using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarksCount : MonoBehaviour
{
    [SerializeField] private float[] _MarksInBlocks = new float[5];
    [SerializeField] private int _questionsInBlock = 3;

    [SerializeField] private int _currentQuestion = 0;
    [SerializeField] private int _currentBlock = 0;
    [SerializeField] private float _countMarks = 0;
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddMark(float mark)
    { 
        _currentQuestion++;
        _countMarks += mark;
        Debug.LogFormat("������� ����:{0}, ������� ������:{1},  �����:{2}", _currentBlock, _currentQuestion, _countMarks);
        if (_currentQuestion == _questionsInBlock)
        {
            Debug.LogFormat("���� ����������. �� ������� � �����:{0} ������� ������:{1}", _currentBlock, _countMarks);
            _MarksInBlocks[_currentBlock] = _countMarks;
            _currentBlock++;
            _countMarks = 0;
            
        }
    }

    public void ResetMarks()
    {
        _currentQuestion = 0;
        _countMarks = 0;
        _currentBlock = 0;
    }
}
