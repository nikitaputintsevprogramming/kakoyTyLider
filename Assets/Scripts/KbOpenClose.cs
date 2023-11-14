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
        if(_kbScript.TextField.gameObject.name == "phone" && !isPhone)
        {
            _kbScript.TextField.text = "+7";
            isPhone = true;
        }
    }
}
