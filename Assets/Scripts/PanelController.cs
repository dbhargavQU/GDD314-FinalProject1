using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    private List<int> inputValues = new List<int>();
    private int[] code = { 1, 2, 4, 3 };

    [SerializeField] private GameObject objectToEnable;

    public void ButtonClicked(int buttonNumber)
    {
        inputValues.Add(buttonNumber);

        if (inputValues.Count == code.Length && CheckCode())
        {
            objectToEnable.SetActive(true);
        }
    }

    private bool CheckCode()
    {
        for (int i = 0; i < code.Length; i++)
        {
            if (inputValues[i] != code[i])
            {
                inputValues.Clear();
                return false;
            }
        }

        inputValues.Clear();
        return true;
    }
}
