using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    [SerializeField] Text codeText;

    string codeTextValue = "";
    void Update ()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "4747")
        {
            SceneManager.LoadScene(6);
        }
        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
