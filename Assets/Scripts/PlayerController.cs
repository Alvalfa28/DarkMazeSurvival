using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveX = Keyboard.current.aKey.isPressed ? -1 :
              Keyboard.current.dKey.isPressed ? 1 : 0;
        float moveZ = Keyboard.current.sKey.isPressed ? -1 :
                      Keyboard.current.wKey.isPressed ? 1 : 0;

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}
