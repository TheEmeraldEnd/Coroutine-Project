using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCoroutine : MonoBehaviour
{
    string originalString = "Hello World!";
    string displayString;
    int index;

    float typeDelay = .25f;

    IEnumerator TypeString()
    {
        do
        {
            yield return new WaitForSeconds(typeDelay);

            index++;

            displayString += originalString[index];

            Debug.Log(displayString);

        } while (index < originalString.Length);
    }
}
