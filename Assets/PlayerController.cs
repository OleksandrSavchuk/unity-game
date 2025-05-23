using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform cameraTransform;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveX, 0, moveZ).normalized;

        if (direction.magnitude >= 0.1f)
        {
            // Рух відносно камери
            Vector3 moveDir = Quaternion.Euler(0, cameraTransform.eulerAngles.y, 0) * direction;
            transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);

            // Поворот гравця
            transform.forward = moveDir;
        }
    }
}
