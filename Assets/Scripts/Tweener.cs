using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{

    private Tween activeTween;

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        if (activeTween != null && Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
        {
            float fraction = (Time.time - activeTween.StartTime) / activeTween.Duration;
            activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, fraction);
        }
        else if (activeTween != null && Vector3.Distance(activeTween.Target.position, activeTween.EndPos) <= 0.1f)
        {
            activeTween.Target.position = activeTween.EndPos;
            activeTween = null;
        }
    }
}
