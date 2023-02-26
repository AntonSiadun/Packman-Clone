using UnityEngine;

public class NodesDeleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Node"))
        {
            Destroy(collision.gameObject);
        }
    }
}
