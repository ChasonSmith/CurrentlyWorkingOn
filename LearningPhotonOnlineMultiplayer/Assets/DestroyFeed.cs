using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFeed : MonoBehaviour
{
    public float destroyTime;

    private void Awake()
    {
        destroyTime = 4f;

    }

    public void OnEnable()
    {
        Destroy(gameObject, destroyTime);
    }
}
