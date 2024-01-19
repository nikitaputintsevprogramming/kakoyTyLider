using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace UI.Pagination
{ 
    public class MarksCount : MonoBehaviour
    {
        public float[] _MarksInBlocks = new float[5];
        public int _questionsInBlock = 3;

        public int _currentQuestion = 0;
        public int _currentBlock = 0;
        public float _countMarks = 0;

        public Image[] _resultDiagramms;
        public float _speedDiagram = 2f;
        public float _pos100 = 220f;
        public float _size100 = 440f;

        public bool isOnResults;

        [SerializeField] private GameObject CheckFieldsObject; 

        private void Update()
        {
            if (isOnResults)
                MarksResultOn();
        }

        

        public void ResetMarks()
        {
            _currentQuestion = 0;
            _countMarks = 0;
            _currentBlock = 0;
        }

        [ContextMenu("MarksResultOn")]
        //public void MarksResultOn()
        //{
        //    _pos100 = 100 / _MarksInBlocks[0];
        //    _size100 = _pos100 * 2f;
        //    _resultDiagramms[0].rectTransform.anchoredPosition = Vector2.Lerp(_resultDiagramms[0].rectTransform.anchoredPosition, new Vector2(_resultDiagramms[0].rectTransform.anchoredPosition.x, _pos100), _speedDiagram * Time.deltaTime);
        //    _resultDiagramms[0].rectTransform.sizeDelta = Vector2.Lerp(_resultDiagramms[0].rectTransform.sizeDelta,
        //                    new Vector2(_resultDiagramms[0].rectTransform.sizeDelta.x,
        //                    _size100), _speedDiagram * Time.deltaTime);
              
        //}
        public void MarksResultOn()
        { 

            for (int count = 0; count < _MarksInBlocks.Length; count++)
            {
                float result = _MarksInBlocks[count] / 3.0f;
                int roundedResult = Mathf.RoundToInt(result * 100); // Умножаем на 100, чтобы перевести дробное число в проценты и округляем

                //Debug.Log(roundedResult);
                _resultDiagramms[count].GetComponentInChildren<Text>().text = roundedResult.ToString();
                if (result >= 1.6f) // Если результат положительный
                {
                    _resultDiagramms[count].rectTransform.sizeDelta = Vector2.Lerp(_resultDiagramms[count].rectTransform.sizeDelta, new Vector2(_resultDiagramms[count].rectTransform.sizeDelta.x, _size100), _speedDiagram * Time.deltaTime); // Установка размера блока на 100 процентов
                    _resultDiagramms[count].rectTransform.anchoredPosition = Vector2.Lerp(_resultDiagramms[count].rectTransform.anchoredPosition, new Vector2(_resultDiagramms[count].rectTransform.anchoredPosition.x, _pos100), _speedDiagram * Time.deltaTime); // Установка позиции блока на 100 процентов
                }
                else // Если результат требует доработки
                {
                    _resultDiagramms[count].rectTransform.sizeDelta = Vector2.Lerp(_resultDiagramms[count].rectTransform.sizeDelta, new Vector2(_resultDiagramms[count].rectTransform.sizeDelta.x, _size100 * result), _speedDiagram * Time.deltaTime); // Установка размера блока в соответствии с результатом
                    _resultDiagramms[count].rectTransform.anchoredPosition = Vector2.Lerp(_resultDiagramms[count].rectTransform.anchoredPosition, new Vector2(_resultDiagramms[count].rectTransform.anchoredPosition.x, _pos100 * result), _speedDiagram * Time.deltaTime); // Установка позиции блока в соответствии с результатом
                }
            }
        }

        public void ShowRes()
        {
            //CheckFieldsObject.GetComponent<CheckFields>().SaveUserData();
            isOnResults = true;
        }
    }
}