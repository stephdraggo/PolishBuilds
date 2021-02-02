using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadCode : MonoBehaviour
{
    [SerializeField] Text numbers;
    [SerializeField,Min(1)] int loopCount=1;
    int tally=0;
    void Start()
    {

    }


    void Update()
    {
        for (int i = 0; i < loopCount; i++)
        {
            LoopyLoop();
        }
    }

    void LoopyLoop()
    {
        float[] tempFloats = new float[Random.Range(5, 20)];
        tally += tempFloats.Length;
        for (int i = 0; i < tempFloats.Length; i++)
        {
            tempFloats[i] = Random.Range(0f, 1000000f);

            if (i < tempFloats.Length - 1)
            {
                i += Random.Range(-1, 1);
            }
        }

        for (int i = 0; i < tempFloats.Length; i++)
        {
            if (tally < 500)
            {
                numbers.text += ("float no." + i.ToString() + " is " + tempFloats[i].ToString() + ", ");
            }
            else
            {
                tally = 0;
                numbers.text = "Numbers: \n";
            }
        }
    }
}
