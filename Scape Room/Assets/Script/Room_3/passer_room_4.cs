using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class passer_room_4 : MonoBehaviour
{
    [SerializeField] Text codeText;

    string codeTextValue = "";
    void Update ()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "4589")
        {
            SceneManager.LoadScene(4);
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
