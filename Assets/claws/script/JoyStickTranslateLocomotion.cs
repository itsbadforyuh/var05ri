using UnityEngine;

public class JoyStickTranslateLocomotion : MonoBehaviour
{
    

    public Transform head;

    public float moveSpeed = 1;

    private VRInputController input;

    private void Awake()
    {
        input = GetComponent<VRInputController>();
    }

    private void Update()
    {
        Vector2 moveInput = input.Joystick;

        // Convert our moveDirection from *local* space to *world* space.
        Vector3 forward = head.forward;
        forward.y = 0;
        forward = forward.normalized;

        Vector3 right = head.right;
        right.y = 0;
        right = right.normalized;

        Vector3 moveDirection = forward * moveInput.y + right * moveInput.x;

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
