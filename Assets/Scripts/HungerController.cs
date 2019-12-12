using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HungerController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static float Hunger_Value = 50;

    // Start is called before the first frame update
    void Start()
    {
        text = this.transform.GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Hunger: " + Hunger_Value.ToString();
    }

    public void UpdateValue(float value)
    {
        Hunger_Value += value;
        text.text = "Hunger: " + Hunger_Value.ToString();
    }
    public void SetValue(float value)
    {
        Hunger_Value = value;
        text.text = "Hunger: " + Hunger_Value.ToString();
    }
}
