using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;

    public Animator animator;
    IEnumerator coroutineTypeSentence;

    public MoraleController moral;
    public HungerController hunger;
    public FoodController food;

    public GameObject buttonPray;
    public GameObject buttonTalk;
    public GameObject buttonFeast;
    public GameObject buttonNextLevel;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        coroutineTypeSentence = TypeSentence("");
    }
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopCoroutine(coroutineTypeSentence);
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        //Debug.Log("end of conversation");
        animator.SetBool("IsOpen", false);

    }

    public void updateMoral(float val)
    {
        moral.UpdateValue(val);
        buttonPray.SetActive(false);
        buttonTalk.SetActive(false);
        buttonFeast.SetActive(false);
        buttonNextLevel.SetActive(true);
    }
    public void updateFood(float val)
    {
        food.UpdateValue(val);
        buttonPray.SetActive(false);
        buttonTalk.SetActive(false);
        buttonFeast.SetActive(false);
        buttonNextLevel.SetActive(true);
    }
    public void updateHunger(float val)
    {
        hunger.UpdateValue(val);
        buttonPray.SetActive(false);
        buttonTalk.SetActive(false);
        buttonFeast.SetActive(false);
        buttonNextLevel.SetActive(true);
    }
}
