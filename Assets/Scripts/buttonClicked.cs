using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClicked : MonoBehaviour
{

    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(button.ToString());
    }
}
