using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    GameObject item;

    private Tweener tweener;



    void Start()
    {
        tweener = GetComponent<Tweener>();
        tweener.AddTween(item.transform, item.transform.position, new Vector3(2f,-15f,0f), 0.5f);
    }

    
    void Update()
    {
        if (item.transform.position == new Vector3(2.0f, -15.0f, 0.0f))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(7.0f,-15f,0.0f), 1.5f);
        }

        if (item.transform.position == new Vector3(7.0f, -15.0f, 0.0f))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(7.0f, -19.0f, 0.0f), 1.5f);
        }
        if (item.transform.position == new Vector3(7.0f, -19.0f, 0.0f))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(2.0f, -19.0f, 0.0f), 1.5f);
        }
        if (item.transform.position == new Vector3(2.0f, -19.0f, 0.0f))
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(2.0f, -15.0f, 0.0f), 1.5f);
        }
    }
}
