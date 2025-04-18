using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Kunci kursor di tengah layar
    }

    void Update()
    {
        float mouseX = Mouse.current.delta.x.ReadValue() * mouseSensitivity * Time.deltaTime;
        float mouseY = Mouse.current.delta.y.ReadValue() * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Batas atas/bawah

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Rotasi vertikal (kamera)
        playerBody.Rotate(Vector3.up * mouseX); // Rotasi horizontal (player)
    }
}
