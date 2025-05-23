using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 2, -4);
    public float sensitivity = 3f;

    float currentRotationY = 0f;

    void LateUpdate()
    {
        if (target == null) return;

        // Обертання мишкою
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        currentRotationY += mouseX;

        // Створюємо нову позицію камери навколо гравця
        Quaternion rotation = Quaternion.Euler(0f, currentRotationY, 0f);
        Vector3 desiredPosition = target.position + rotation * offset;

        // Камера рухається і дивиться на гравця
        transform.position = desiredPosition;
        transform.LookAt(target.position + Vector3.up * 1.5f); // трохи вище, щоб дивилась на голову
    }
}
