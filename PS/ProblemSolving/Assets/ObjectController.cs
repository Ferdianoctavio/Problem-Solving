using UnityEngine;

public class ObjectController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}