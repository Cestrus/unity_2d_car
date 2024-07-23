using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField]
    float destroyDelay = 0.5f;

    [SerializeField]
    Color32 hasPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField]
    Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Boom!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.tag == "Package")
        if (other.CompareTag("Package") && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.CompareTag("Customer"))
        {
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
