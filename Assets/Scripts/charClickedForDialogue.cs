using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class charClickedForDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public GameObject buttonPray;
    public GameObject buttonFeast;
    public GameObject buttonTalk;
    public DialogueTrigger dialogueTrigger;
    public bool clicked;
    void Start()
    {
        character = this.gameObject;
        clicked = false;
        var child = character.transform.GetChild(0);
        child.GetComponent<TextMeshPro>().text = "!";
        child.GetComponent<TextMeshPro>().fontStyle = FontStyles.Bold;
    }

    private void OnMouseDown()
    {
        if (!clicked)
        {
            dialogueTrigger.TriggerDialogue();
            clicked = true;
            var child = character.transform.GetChild(0);
            child.GetComponent<TextMeshPro>().text = "";
            /*if(character.name == "charPriest")
            {
                buttonPray.SetActive(true);
                buttonTalk.SetActive(true);
            }
            else if(character.name == "charThyrker")
            {
                buttonFeast.SetActive(true);
            }*/
        }
    }
}
