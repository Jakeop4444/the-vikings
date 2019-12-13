using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public static float Food_Value = 50;

    // Start is called before the first frame update
    void Start()
    {
        text = this.transform.GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Food: " + Food_Value.ToString();
    }

    public void UpdateValue(float value)
    {
        Food_Value += value;
        text.text = "Food: " + Food_Value.ToString();
    }
    public void SetValue(float value)
    {
        Food_Value = value;
        text.text = "Hunger: " + Food_Value.ToString();
    }
    public float getValue()
    {
        return Food_Value;
    }
}
