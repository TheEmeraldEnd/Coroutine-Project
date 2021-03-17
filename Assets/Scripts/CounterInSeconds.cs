using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterInSeconds : MonoBehaviour
{
    Text text;
    int secondsPassed;

    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine(AddSecond());
    }

    IEnumerator AddSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            secondsPassed++;
            text.text = $"You have spent {secondsPassed:N} seconds with scarecrow";
        }
    }

}
