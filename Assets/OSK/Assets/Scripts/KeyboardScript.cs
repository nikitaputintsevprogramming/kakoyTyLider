using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardScript : MonoBehaviour
{

    public InputField TextField;
    [SerializeField] private InputField[] TextFields;
    public GameObject RusLayoutSml, RusLayoutBig, EngLayoutSml, EngLayoutBig, SymbLayout;

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
        for (int count = 0; count <= TextFields.Length - 1; count++)
        {
            //Debug.Log(count);
            Debug.Log(TextFields[count].isFocused);
            if (TextFields[count].isFocused)
                TextField = TextFields[count];
        }
    }



    public void alphabetFunction(string alphabet)
    {


        TextField.text=TextField.text + alphabet;

    }

    public void BackSpace()
    {

        if(TextField.text.Length>0) TextField.text= TextField.text.Remove(TextField.text.Length-1);

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
