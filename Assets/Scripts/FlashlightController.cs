using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight;
    public float batteryLife = 100f;
    public float drainRate = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
        }

        if (flashlight.enabled)
        {
            batteryLife -= drainRate * Time.deltaTime;
            if (batteryLife <= 0)
            {
                flashlight.enabled = false;
            }
        }
    }
}
