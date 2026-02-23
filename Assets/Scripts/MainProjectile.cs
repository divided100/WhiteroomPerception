using UnityEngine;
public class MainProjectile : MonoBehaviour
{
    public float speed = 6f;
    public ToggleObject stageTrigger;
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
            if (stageTrigger != null)
            {
                stageTrigger.ActivateStage();
            }

            return;
        }
        direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        direction.Normalize();
    }
}