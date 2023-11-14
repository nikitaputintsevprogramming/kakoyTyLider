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
                if (TextFields[count].text.Length != 0 && checkMark.isOn)
                {
                    if(TextFields[count].gameObject.name == "phone")
                    {
                        if(TextFields[count].text.Length >= 11 && TextFields[count].text.Contains("+7"))
                        {
                            Debug.Log("������� �����");
                        }
                        else
                        {
                            Debug.Log("������� �� �����!");
                            break;
                        }
                    }
                    if (TextFields[count].gameObject.name == "email")
                    {
                        if (TextFields[count].text.Length >= 3 && TextFields[count].text.Contains("@"))
                        {
                            Debug.Log("����� �����");
                            
                        }
                        else
                        {
                            Debug.Log("����� �� �����!");
                            break;
                        }
                    }

                    vertPag.GetComponent<PagedRect>().NextPage();
                }
                else
                {
                    Debug.Log("��������� ��� ����!");
                    StartCoroutine(FeelTheField(count));
                    break;
                }
            }
        }

        private IEnumerator FeelTheField(int num)
        {
            // ������������� ��������� �������� �����-������
            float alpha = 255;

            // ��������� �����-����� �� 255 �� 0
            while (alpha > 0)
            {
                alpha -= Time.deltaTime * 50; // ��������� �������� �������� �� ������ �������
                TextFields[num].GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
            // ����������� �����-����� �� 0 �� 255
            while (alpha < 255)
            {
                alpha += Time.deltaTime * 50; // ��������� �������� �������� �� ������ �������
                TextFields[num].GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
        }
    }
}