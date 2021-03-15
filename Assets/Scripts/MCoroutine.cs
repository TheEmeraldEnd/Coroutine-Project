using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCoroutine : MonoBehaviour
{
    string originalString = "Hello World!";
    string displayString;
    int index;

    float typeDelay = .25f;

    private void Start()
    {
        StartCoroutine(TypeString());
    }

    IEnumerator TypeString()
    {
        do
        {
            yield return new WaitForSeconds(typeDelay);

            displayString += originalString[index];

            Debug.Log(displayString);

            index++;

        } while (index < originalString.Length);
    }
}
