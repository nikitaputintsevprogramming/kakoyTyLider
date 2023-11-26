using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KbOpenClose : MonoBehaviour, ISelectHandler
{
    [SerializeField] private GameObject OSK;
    [SerializeField] private KeyboardScript _kbScript;
    [SerializeField] private bool isPhone;

    public void OpenClose()
    {
        OSK.SetActive(!OSK.activeSelf);
    }

    public void OnSelect(BaseEventData eventData)
    {
        OSK.SetActive(true);
        _kbScript.TextField = gameObject.GetComponent<InputField>();
        if (_kbScript.TextField.gameObject.name == "phone" && _kbScript.TextField.text.Length == 0)
        {
            _kbScript.CloseAllLayouts();
            _kbScript.ShowLayout(_kbScript.RusLayoutBig);
            _kbScript.TextField.text = "+7";
        }

        if (_kbScript.TextField.gameObject.name == "surname" && _kbScript.TextField.text.Length == 0)
        {
            _kbScript.CloseAllLayouts();
            _kbScript.ShowLayout(_kbScript.RusLayoutBig);
            print(_kbScript.TextField);
        }

        else if (_kbScript.TextField.gameObject.name == "name" && _kbScript.TextField.text.Length == 0)
        {
            _kbScript.CloseAllLayouts();
            _kbScript.ShowLayout(_kbScript.RusLayoutBig);
            print(_kbScript.TextField);
        }
        else if (_kbScript.TextField.gameObject.name == "father" && _kbScript.TextField.text.Length == 0)
        {
            _kbScript.CloseAllLayouts();
            _kbScript.ShowLayout(_kbScript.RusLayoutBig);
            print("father");
        }
        else if(_kbScript.TextField.gameObject.name == "father" || _kbScript.TextField.gameObject.name == "name" || _kbScript.TextField.gameObject.name == "surname" && _kbScript.TextField.text.Length <= 10)
        {
            _kbScript.CloseAllLayouts();
            _kbScript.ShowLayout(_kbScript.RusLayoutSml);
        }

        if (_kbScript.TextField.gameObject.name == "email" && _kbScript.TextField.text.Length == 0)
        {
            _kbScript.CloseAllLayouts();
            _kbScript.ShowLayout(_kbScript.EngLayoutSml);
            print("email");
        }
    }
}
