using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace UI.Pagination
{
    public class CheckFields : MonoBehaviour
    {
        [SerializeField] private InputField[] TextFields;
        [SerializeField] private Toggle checkMark;

        [SerializeField] private GameObject vertPag;

        public string path = ""; // путь к файлу
        public string nameFile = "DataOfUsers.txt"; // название файла
        private string filePath = "DataOfUsers.txt";

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
                            if (checkMark.isOn)
                            {
                                Debug.Log("галочка стоит");
                            }
                            else
                            {
                                Debug.Log("Поставьте галочку!");
                                StartCoroutine(FeelTheMark());
                            }
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
                            if (checkMark.isOn)
                            {
                                //OnSave();
                                SaveUserData();
                                vertPag.GetComponent<PagedRect>().NextPage();
                            }
                            else
                            {
                                Debug.Log("Поставьте галочку!");
                                StartCoroutine(FeelTheMark());
                            }
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

        public void OnSave()
        { // функция сохранения
            StreamWriter sw = new StreamWriter(path + "/" + nameFile); // создаём файл
            for (int count = 0; count < TextFields.Length; count++)
            {
                sw.WriteLine(TextFields[count].text); // записываем в файл строку
            }
            sw.Close(); // закрываем файл
        }

        public void SaveUserData()
        {
            string userData = "";

            foreach (InputField inputField in TextFields)
            {
                userData += inputField.text + " ";
            }

            WriteToFile(userData.Trim());
        }

        private void WriteToFile(string data)
        {
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, data + "\n");
            }
            else
            {
                File.WriteAllText(filePath, data + "\n");
            }
        }

        private IEnumerator FeelTheField(int num)
        {
            // Устанавливаем начальное значение альфа-канала
            float alpha = 255;

            // Уменьшаем альфа-канал от 255 до 0
            while (alpha > 0)
            {
                alpha -= Time.deltaTime * 250f; // Изменение скорости анимации по вашему желанию
                TextFields[num].GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
            // Увеличиваем альфа-канал от 0 до 255
            while (alpha < 255)
            {
                alpha += Time.deltaTime * 250f; // Изменение скорости анимации по вашему желанию
                TextFields[num].GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
        }
        private IEnumerator FeelTheMark()
        {
            // Устанавливаем начальное значение альфа-канала
            float alpha = 255;

            // Уменьшаем альфа-канал от 255 до 0
            while (alpha > 0)
            {
                alpha -= Time.deltaTime * 250f; // Изменение скорости анимации по вашему желанию
                checkMark.transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
            // Увеличиваем альфа-канал от 0 до 255
            while (alpha < 255)
            {
                alpha += Time.deltaTime * 250f; // Изменение скорости анимации по вашему желанию
                checkMark.transform.GetChild(0).GetComponent<Image>().color = new Color32(255, 255, 255, (byte)alpha);
                yield return null;
            }
        }
    }
}