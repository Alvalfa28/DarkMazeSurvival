using UnityEngine;
using UnityEngine.InputSystem;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight;
    public float batteryLife = 100f;
    public float drainRate = 5f;

    void Update()
    {
        // Cek apakah tombol F ditekan dalam frame ini
        if (Keyboard.current.fKey.wasPressedThisFrame && flashlight != null)
        {
            flashlight.enabled = !flashlight.enabled;
        }

        // Jika senter menyala, kurangi baterai
        if (flashlight != null && flashlight.enabled)
        {
            batteryLife -= drainRate * Time.deltaTime;
            if (batteryLife <= 0)
            {
                batteryLife = 0;
                flashlight.enabled = false;
            }
        }
    }
}
