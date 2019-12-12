using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float Food_Value;

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
}
