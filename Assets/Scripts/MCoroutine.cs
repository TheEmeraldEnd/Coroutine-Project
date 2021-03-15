using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MCoroutine : MonoBehaviour
{
    public string originalString = "Hello World!";
    string displayString;
    int index;

    public float typeDelay = .25f;
    public Text displayText;

    private void Start()
    {
        StartCoroutine(TypeString());
    }

    IEnumerator TypeString()
    {
        do
        {
            //Delays in specified seconds
            yield return new WaitForSeconds(typeDelay);

            displayString += originalString[index];

            displayText.text = displayString;

            index++;

        } while (index < originalString.Length);
    }
}
