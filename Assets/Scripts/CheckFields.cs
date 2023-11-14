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
                if (TextFields[count].text.Length != 0 )
                {
                    if (TextFields[count].gameObject.name == "email")
                    {
                        if (TextFields[count].text.Length >= 3 && TextFields[count].text.Contains("@"))
                        {
                            Debug.Log("почта верна");
                        }
                        else
                        {
                            Debug.Log("почта не верна!");
                            StartCoroutine(FeelTheField(count));
                            break;
                        }
                    }
                    if (TextFields[count].gameObject.name == "phone")
                    {
                        if (TextFields[count].text.Length >= 11 && TextFields[count].text.Contains("+7"))
                        {
                            Debug.Log("телефон верен");
                            vertPag.GetComponent<PagedRect>().NextPage();
                        }
                        else
                        {
                            Debug.Log("телефон не верен!");
                            StartCoroutine(FeelTheField(count));
                            break;
                        }
                    }
                }
                else
                {
                    Debug.Log("Заполните все поля!");
                    StartCoroutine(FeelTheField(count));
                    break;
                }
            }
        }

        private IEnumerator FeelTheField(int num)
        {
            // Устанавливаем начальное значение альфа-канала
            float alpha = 255;

            // Уменьшаем альфа-канал от 255 до 0
            while (alpha > 0)
            {
                alpha -= Time.deltaTime * 200; // Изменение скорости анимации по вашему желанию
                TextFields[num].GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
            // Увеличиваем альфа-канал от 0 до 255
            while (alpha < 255)
            {
                alpha += Time.deltaTime * 200; // Изменение скорости анимации по вашему желанию
                TextFields[num].GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
        }
    }
}