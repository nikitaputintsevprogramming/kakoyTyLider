using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KbOpenClose : MonoBehaviour
{
    [SerializeField] private GameObject OSK;

    public void OpenClose()
    {
        OSK.SetActive(!OSK.activeSelf);
    }
}
