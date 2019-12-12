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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*(if (Input.GetKeyDown(KeyCode.Space))
        {
            FadeToNextLevel();
        }*/
    }

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        dialogueManager.updateMoral(changeInMorale);
        dialogueManager.updateHunger(changeInHunger);
        dialogueManager.updateFood(changeInFood);
        SceneManager.LoadScene(levelToLoad);
    }

    
}
