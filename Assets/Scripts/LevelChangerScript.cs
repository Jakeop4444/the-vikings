using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangerScript : MonoBehaviour
{

    public Animator animator;
    private int levelToLoad;
    public DialogueManager dialogueManager;
    //below are the variables that are changed in between scenes. They are updated when a scene ends
    public float changeInMorale;
    public float changeInHunger;
    public float changeInFood;

    public void FadeToNextLevel()
    {
        if(dialogueManager.moral.getValue() < 0 || dialogueManager.hunger.getValue() < 0 || dialogueManager.food.getValue() < 0)
        {
            FadeToLevel(9);
        }
        else
        {
            FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        if (SceneManager.GetActiveScene().name == "Title")
        {
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            dialogueManager.updateMoral(changeInMorale);
            dialogueManager.updateHunger(changeInHunger);
            dialogueManager.updateFood(changeInFood);
            SceneManager.LoadScene(levelToLoad);
        }
        
    }

}
