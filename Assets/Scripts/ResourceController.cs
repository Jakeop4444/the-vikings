using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceController : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float Resource_Value;

    // Start is called before the first frame update
    void Start()
    {
        text = this.transform.GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Resources: " + Resource_Value.ToString();
    }

    public void UpdateValue(float value)
    {
        Resource_Value += value;
        text.text = "Resources: " + Resource_Value.ToString();
    }
}
