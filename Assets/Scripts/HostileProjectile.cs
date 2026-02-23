using UnityEngine;
using UnityEngine.SceneManagement;
public class HostileProjectile : MonoBehaviour
{
    public float speed = 6f;
    private Vector3 direction;
    void Start()
    {
        direction = new Vector3(1, 0, 1).normalized;
    }
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            return;
        }
        direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        direction.Normalize();
    }
}