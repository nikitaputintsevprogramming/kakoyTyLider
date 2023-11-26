using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Pagination
{
    public class ChangerRecommneds : MonoBehaviour
    {
        [SerializeField] private MarksCount _marksManager;
        [SerializeField] private int _part;

        [SerializeField] private Sprite _more;
        [SerializeField] private Sprite _less;

        void Start()
        {
            if (_marksManager._MarksInBlocks[_part] >= 1.9f)
                transform.GetComponent<Image>().sprite = _more;
            else
                transform.GetComponent<Image>().sprite = _less;
        }

        void Update()
        {

        }
    }
}