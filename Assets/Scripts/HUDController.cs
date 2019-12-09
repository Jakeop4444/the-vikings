using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public GameObject modal;

    public GameObject morale;
    public GameObject morale_text;

    public GameObject resources;
    public GameObject resources_text;

    // Start is called before the first frame update
    void Start()
    {
        //modal.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //most of this code is just for show, setactive's will need to be just disabling renderers later
        if (modal.activeSelf == true)
        {
            //these will just disable the renderer, not deactivate object
            morale_text.SetActive(false);
            resources.SetActive(false);
            if (Input.anyKey)
            {
                modal.SetActive(false);
                morale_text.SetActive(true);
                resources.SetActive(true);
            }
        }

        //purely for example, this will be activated by event triggers in the game later
        if (Input.GetKey(KeyCode.F1))
        {
            modal.SetActive(true);
        }
    }
}
