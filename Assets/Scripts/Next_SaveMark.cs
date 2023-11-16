using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Pagination
{
    public class Next_SaveMark : MarksCount
    {
        public Button[] choices;
        public Choice ChoiceScript;
        public MarksCount _marksCount;

        void Start()
        {

        }

        void Update()
        {

        }

        public void AddMark()
        {
            float mark = 0;

            for(int count = 0; count < choices.Length; count++)
            {
                print(choices[count].GetComponent<Image>().sprite.name == "white");
                if(choices[count].GetComponent<Image>().sprite == ChoiceScript._whiteButton)
                {
                    print("она белая");
                    mark = choices[count].GetComponent<Choice>().markButton;
                }
            }

            _marksCount._currentQuestion++;
            _marksCount._countMarks += mark;
            Debug.LogFormat("Текущий блок:{0}, текущий вопрос:{1},  баллы:{2}", _marksCount._currentBlock, _marksCount._currentQuestion, _marksCount._countMarks);
            if (_marksCount._currentQuestion == _marksCount._questionsInBlock)
            {
                Debug.LogFormat("Блок закончился. Вы набрали в блоке:{0} столько баллов:{1}", _marksCount._currentBlock, _marksCount._countMarks);
                _marksCount._MarksInBlocks[_marksCount._currentBlock] = _marksCount._countMarks;
                _marksCount._currentBlock++;
                _marksCount._currentQuestion = 0;
                _marksCount._countMarks = 0;
            }
        }
    }
}