using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextObject : MonoBehaviour
{
    Text text;
    public static float damage;
    
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        Invoke(nameof(Destroy), 5);
    }

    private void Update()
    {
        text.text = damage.ToString();
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
