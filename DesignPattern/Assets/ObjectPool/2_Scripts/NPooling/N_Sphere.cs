using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_Sphere : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Renderer renderer;

    [SerializeField] float upForce = 50f;
    [SerializeField] float sideForce = 1f;

    private void Start()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce * 0.5f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);
        Vector3 force = new Vector3(xForce, yForce, zForce);
        rigidbody.velocity = force;

        Invoke(nameof(DeactiveDelay), 5);
    }

    public void Setup(Color color)
    {
        renderer.material.color = color;
    }

    void DeactiveDelay() => Destroy(gameObject);
}
