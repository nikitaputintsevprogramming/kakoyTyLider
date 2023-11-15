using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardScript : MonoBehaviour
{
    public InputField TextField;
    //[SerializeField] private InputField[] TextFields;
    public GameObject cursor;
    public GameObject RusLayoutSml, RusLayoutBig, EngLayoutSml, EngLayoutBig, SymbLayout;

    public int arrowPos;
    

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    SelectField();
        //}

        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        SelectField();
        //    }
        //}

        //for (int count = 0; count <= TextFields.Length - 1; count++)
        //{
        //    //Debug.Log(TextFields[count].isFocused);
        //    if (TextFields[count].isFocused)
        //    {
        //        TextField = TextFields[count];
        //        //cursor.transform.position = TextField.transform.position;
        //        if(TextField.name == "phone")
        //        {
                    
        //            TextFields[count].text = "+7";   
        //        }
        //    }
        //}

        //Debug.Log(TextField.caretPosition);
        
    }

    public void LeftArrowFunction()
    {   
        //if (TextField.caretPosition >= TextField.text.Length)
            TextField.caretPosition = TextField.caretPosition + 1;
        print(TextField.caretPosition);
    }

    public void RightArrowFunction()
    {
        //if (TextField.caretPosition <= 0)
            TextField.caretPosition = TextField.caretPosition - 1;
        print(TextField.caretPosition);
    }

    public void alphabetFunction(string alphabet)
    {
        TextField.text = TextField.text.Insert(TextField.text.Length - TextField.caretPosition, alphabet);

        if (TextField.gameObject.name == "name" && TextField.text.Length == 0)
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutBig);
        }
        else if (TextField.gameObject.name == "surname" && TextField.text.Length == 0)
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutBig);
        }
        else if (TextField.gameObject.name == "father" && TextField.text.Length == 0)
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutBig);
        }
        else if (TextField.text.Length <= 1)
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutSml);
        }

        //TextField.Select();
        //RightArrowFunction();
        //TextField.caretPosition = TextField.text.Length;
        //TextField.text.Insert(TextField.caretPosition, alphabet);

        //TextField.ForceLabelUpdate();
        //TextField.MoveTextEnd(true);
        //TextField.ActivateInputField();
    }

    public void BackSpace()
    {
        //if(TextField.text.Length>0) TextField.text= TextField.text.Remove(TextField.text.Length-1, 1);
        if (TextField.caretPosition > 0)
        {
            int leftIndex = TextField.caretPosition + 1;
            TextField.text = TextField.text.Remove(leftIndex, 1);
            //RightArrowFunction();
        }
        else
        {
            TextField.text = TextField.text.Remove(TextField.text.Length - 1);
        }

        if (TextField.gameObject.name == "name" && TextField.text.Length == 0 )
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutBig);
        }

        else if (TextField.gameObject.name == "surname" && TextField.text.Length == 0)
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutBig);
        }

        else if (TextField.gameObject.name == "father" && TextField.text.Length == 0)
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutBig);
        }

        else if(TextField.text.Length <= 1)
        {
            CloseAllLayouts();
            ShowLayout(RusLayoutSml);
        }

    }

    public void CloseAllLayouts()
    {
        RusLayoutSml.SetActive(false);
        RusLayoutBig.SetActive(false);
        EngLayoutSml.SetActive(false);
        EngLayoutBig.SetActive(false);
        SymbLayout.SetActive(false);
    }

    public void ShowLayout(GameObject SetLayout)
    {
        CloseAllLayouts();
        SetLayout.SetActive(true);
    }
}
