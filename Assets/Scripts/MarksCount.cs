using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Marks
{ 
    public class MarksCount : MonoBehaviour
    {
        [SerializeField] private float[] _MarksInBlocks = new float[5];
        [SerializeField] private int _questionsInBlock = 3;

        [SerializeField] private int _currentQuestion = 0;
        [SerializeField] private int _currentBlock = 0;
        [SerializeField] private float _countMarks = 0;

        public Image[] _resultDiagramms;
        [SerializeField] private float _speedDiagram = 2f;

        [SerializeField] private bool isOnResults;

        private void Update()
        {
            if (isOnResults)
                MarksResultOn();
        }

        public void AddMark(float mark)
        { 
            _currentQuestion++;
            _countMarks += mark;
            Debug.LogFormat("Текущий блок:{0}, текущий вопрос:{1},  баллы:{2}", _currentBlock, _currentQuestion, _countMarks);
            if (_currentQuestion == _questionsInBlock)
            {
                Debug.LogFormat("Блок закончился. Вы набрали в блоке:{0} столько баллов:{1}", _currentBlock, _countMarks);
                _MarksInBlocks[_currentBlock] = _countMarks;
                _currentBlock++;
                _currentQuestion = 0;
                _countMarks = 0;
            }
        }

        public void ResetMarks()
        {
            _currentQuestion = 0;
            _countMarks = 0;
            _currentBlock = 0;
        }

        [ContextMenu("MarksResultOn")]
        public void MarksResultOn()
        {
            _resultDiagramms[0].rectTransform.anchoredPosition = Vector2.Lerp(_resultDiagramms[0].rectTransform.anchoredPosition, new Vector2(_resultDiagramms[0].rectTransform.anchoredPosition.x, 225f), _speedDiagram * Time.deltaTime);
            _resultDiagramms[0].rectTransform.sizeDelta = Vector2.Lerp(_resultDiagramms[0].rectTransform.sizeDelta,
                            new Vector2(_resultDiagramms[0].rectTransform.sizeDelta.x,
                            450f), _speedDiagram * Time.deltaTime);
        }

        public void ShowRes()
        {
            isOnResults = true;
        }
    }
}