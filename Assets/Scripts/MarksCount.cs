using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarksCount : MonoBehaviour
{
    [SerializeField] private int _blocks = 5;
    [SerializeField] private int _questionsInBlock = 3;

    [SerializeField] private int _currentQuestion = 1;
    [SerializeField] private float _countMarks = 0;
    [SerializeField] private int[] _currentMarks;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AddMark(float mark)
    {
        print(mark);

        _currentQuestion++;
        _countMarks += mark;
        if (_currentQuestion > _questionsInBlock)
        {
            Debug.LogFormat("Блок закончился. Вы набрали в блоке:{0} столько баллов:{1}", "ХЗ пока", _countMarks);
            _countMarks = 0;
        }
    }

    public void ResetMarks()
    {
        _currentQuestion = 0;
        _countMarks = 0;
        
    }
}
