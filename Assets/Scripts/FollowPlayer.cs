using UnityEngine;
public class FollowPlayer : MonoBehaviour
{public GameObject player;
    public float mouseSensitivity = 2f;
    public float maxAngleX = 30f;
    private float verticalRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        player.transform.Rotate(Vector3.up * mouseX);
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -maxAngleX, maxAngleX);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        transform.position = player.transform.position + new Vector3(0, 0.5f, 0);
    }
}
