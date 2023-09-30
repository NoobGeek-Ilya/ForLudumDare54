using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

public class SParameter : MonoBehaviour
{
    private Toggle[] parameters;
    internal protected static bool[] isActive;

    void Start()
    {
        parameters = GetComponentsInChildren<Toggle>();
        isActive = new bool[parameters.Length];
        SetStartValue();
    }

    void SetStartValue()
    {
        for (int i = 0; i < parameters.Length; i++)
        {
            float value = Random.value;
            isActive[i] = value > 0.5f;
            parameters[i].isOn = value > 0.5f;
        }
    }
}
