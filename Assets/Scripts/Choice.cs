using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    [SerializeField] private GameObject[] _buttons;
    [SerializeField] private Button _nextButton;
    public Sprite _whiteButton;
    [SerializeField] private Sprite _redButton;

    [SerializeField] private Sprite _whiteButtonNext;
    [SerializeField] private Sprite _noneButtonNext;

    public float markButton;

    private bool isClicked = false;

    void Start()
    {
        _nextButton.interactable = false;
    }

    void Update()
    {
        
    }

    public void ChangeButton()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            ResetButton();
        }

        transform.GetComponent<Image>().sprite = _whiteButton;
        transform.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        for (int i = 0; i < transform.GetComponentsInChildren<Text>().Length; i++)
        {
            transform.GetComponentsInChildren<Text>()[i].color = Color.black;
        }

        for (int i = 0; i < _buttons.Length; i++)
        {
            //_buttons[i].GetComponent<Button>().interactable = false;
        }

        _nextButton.GetComponent<Image>().sprite = _whiteButtonNext;
        _nextButton.interactable = true;
    }

    public void ResetButton()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i].GetComponent<Button>().interactable = true;
            _buttons[i].GetComponent<Image>().sprite = _redButton;
            //_buttons[i].GetComponent<Image>().color = new Color32(248, 165, 186, 255);
            for (int b = 0; b < _buttons[i].GetComponentsInChildren<Text>().Length; b++)
            {
                _buttons[i].GetComponentsInChildren<Text>()[b].color = Color.white;
            }
        }

        _nextButton.GetComponent<Image>().sprite = _noneButtonNext;
        _nextButton.interactable = false;
    }
}
