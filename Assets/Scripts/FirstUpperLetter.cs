using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstUpperLetter : MonoBehaviour
{
    public void SetFirstLetterUppercase(InputField inputf)
    {
        if(inputf.text.Length > 0  && inputf.text.Length <= 1)
        {
            string currentText = inputf.text;
            string newText = currentText.Substring(0, 1).ToUpper() + currentText.Substring(1);
            inputf.text = newText;
        }
    }

    //public void SetFirstLetterUppercase(InputField inputf)
    //{
    //    if (inputf.text.Length > 0 && inputf.text.Length <= 1)
    //    {
    //        _kbScript.CloseAllLayouts();
    //        _kbScript.ShowLayout(_kbScript.RusLayoutBig);
    //        string currentText = inputf.text;
    //        string newText = currentText.Substring(0, 1).ToUpper() + currentText.Substring(1);
    //        inputf.text = newText;
    //    }
    //    else
    //    {
    //        _kbScript.CloseAllLayouts();
    //        _kbScript.ShowLayout(_kbScript.RusLayoutSml);
    //    }
    //}
}
