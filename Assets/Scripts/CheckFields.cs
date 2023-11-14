using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Pagination
{
    public class CheckFields : MonoBehaviour
    {
        [SerializeField] private InputField[] TextFields;
        [SerializeField] private Toggle checkMark;

        [SerializeField] private GameObject vertPag;

        public void CheckAnswersInFields()
        {
            for (int count = 0; count < TextFields.Length; count++)
            {
                if (TextFields[count].text.Length != 0)
                {
                    vertPag.GetComponent<PagedRect>().NextPage();
                }
                else
                {
                    Debug.Log("Заполните все поля!");
                }
            }
        }
    }
}