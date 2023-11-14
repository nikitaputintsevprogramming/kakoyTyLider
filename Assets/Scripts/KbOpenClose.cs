using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KbOpenClose : MonoBehaviour, ISelectHandler
{
    [SerializeField] private GameObject OSK;

    public void OpenClose()
    {
        OSK.SetActive(!OSK.activeSelf);
    }

    public void OnSelect(BaseEventData eventData)
    {
        OSK.SetActive(true);
    }
}
