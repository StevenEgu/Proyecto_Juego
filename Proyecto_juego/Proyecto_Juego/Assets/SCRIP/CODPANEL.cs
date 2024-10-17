using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CODPANEL : MonoBehaviour
{
    [SerializeField]
    Text codeText;
    string codeTextValue = "";

    void Update()
    {
        codeText.text = codeTextValue;

        if(codeTextValue=="9999")
        {
            COD.isSafeOpened = true;
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue+= digit;
    }
}
