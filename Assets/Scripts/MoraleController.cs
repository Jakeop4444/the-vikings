using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoraleController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float Morale_Value;

    // Start is called before the first frame update
    void Start()
    {
        text = this.transform.GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Morale: " + Morale_Value.ToString();
    }

    public void UpdateValue(float value)
    {
        Morale_Value += value;
        text.text = "Morale: " + Morale_Value.ToString();
    }
}
