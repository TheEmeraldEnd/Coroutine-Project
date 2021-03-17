using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterInSeconds : MonoBehaviour
{
    Text text;
    int secondsPassed;

    void OnUpdate()
    {
        StartCoroutine(AddSecond());
    }

    IEnumerator AddSecond()
    {
        yield return new WaitForSeconds(1);
        secondsPassed++;
        text.text = secondsPassed.ToString();
    }

}
