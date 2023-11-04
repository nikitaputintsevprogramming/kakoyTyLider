using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uppercaseNames : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Text>().text = transform.GetComponent<Text>().text.ToUpper();
        transform.GetComponent<Text>().fontSize = 24;
        transform.GetComponent<Text>().resizeTextForBestFit = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
