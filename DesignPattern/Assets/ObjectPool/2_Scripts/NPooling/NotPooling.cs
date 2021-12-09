using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotPooling : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject sphere;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject NCube = Instantiate(cube, transform);
                NCube.GetComponent<N_Cube>().Setup(Random.ColorHSV(0, 1, 0.5f, 1, 1, 1));
                GameObject NSphere = Instantiate(sphere, transform);
                NSphere.GetComponent<N_Sphere>().Setup(Random.ColorHSV(0, 1, 0.5f, 1, 1, 1));
            }
        }
    }
}
