using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charRNDMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public bool rndMove;
    public float speed;
    GameObject character;
    IEnumerator coroutine;

    void Start()
    {
        rndMove = true;
        speed = 8.0f;
        character = this.gameObject;
        coroutine = rndCharMove();
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator rndCharMove()
    {
        while (rndMove)
        {
            int direction = Mathf.RoundToInt((1 + Random.Range(0f, 9f))); //generates a rnd number between 1 and 10. if the number is less than 8, the char does nothing
                                                                          //i chose to ignore 10 cuz i felt like 9 was getting picked way more than 10 was
            var tempPos = character.transform.position;
            if (direction == 8) // move left
            {
                tempPos.x -= speed * Time.deltaTime;
                character.GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (direction == 9) // move right
            {
                tempPos.x += speed * Time.deltaTime;
                character.GetComponent<SpriteRenderer>().flipX = true;
            }
            character.transform.position = tempPos;
            Debug.Log(this.gameObject.name + ": " + direction);
            yield return new WaitForSecondsRealtime(1);
        }
        yield return new WaitForSecondsRealtime(1);
    }

    private void OnMouseDown()
    {
        
    }
}
