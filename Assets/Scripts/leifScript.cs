using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leifScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool shouldLerp;

    public float timeStartedLerping;
    public float lerpTime;

    public Vector2 startPos;
    public Vector2 endPos;

    public GameObject charLeif;
    void Start()
    {
        charLeif = this.gameObject;
        shouldLerp = false;
        startPos = charLeif.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldLerp)
        {
            transform.position = Lerp(startPos, endPos, timeStartedLerping, lerpTime);
        }
    }

    public void StartLerping(Vector2 pos)
    {
        endPos = pos;
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 3)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percentageComplete);
        shouldLerp = false;
        return result;
    }

}
