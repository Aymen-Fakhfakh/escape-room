using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code : MonoBehaviour
{
    [SerializeField] Text codeText;
    [SerializeField] private GameObject popup_1 ;
    [SerializeField] private GameObject popup_2 ;

    string codeTextValue = "";
    void Update ()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "@*#")
        {
            popup_1.SetActive(true);
            popup_2.SetActive(false);
        }
        if (codeTextValue.Length >= 3)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }


}
