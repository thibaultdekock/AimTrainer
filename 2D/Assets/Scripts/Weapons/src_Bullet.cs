using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src_Bullet : MonoBehaviour
{
    [Header("Settings")]
    public float lifeTime = 1;

    private void Awake()
    {
        Destroy(gameObject, lifeTime);
    }
}
