using UnityEngine;

public class Artifact : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CollectArtifact();
            Destroy(gameObject);
        }
    }

}
