using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pooling;

public class Sphere : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Renderer renderer;

    [SerializeField] float upForce = 1f;
    [SerializeField] float sideForce = 0.1f;

    private void OnEnable()
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

    void DeactiveDelay() => gameObject.SetActive(false);

    private void OnDisable()
    {
        ObjectPooler.ReturnToPool(gameObject);
        CancelInvoke();
    }
}
