using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pooling;

public class Test : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ObjectPooler.SpawnFromPool<Sphere>("Sphere", Vector2.zero).Setup(Random.ColorHSV(0, 1, 0.5f, 1, 1, 1));

            ObjectPooler.SpawnFromPool<Cube>("Cube", Vector2.zero).Setup(Random.ColorHSV(0, 1, 0.5f, 1, 1, 1));
        }
    }
}
