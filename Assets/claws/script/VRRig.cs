using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.InputSystem;

public class VRRig : MonoBehaviour
{
    public Transform head, left, right;

    private void Update()
    {
        if (XRController.leftHand != null)
        {
            Debug.Log("here");
            Vector3 leftPosition = XRController.leftHand.devicePosition.ReadValue();
            Quaternion leftRotation = XRController.leftHand.deviceRotation.ReadValue();

            left.localPosition = leftPosition;
            left.localRotation = leftRotation;
        }
        else { Debug.Log("nothing"); }

        if (XRController.rightHand != null)
        {
            Vector3 rightPosition = XRController.rightHand.devicePosition.ReadValue();
            Quaternion rightRotation = XRController.rightHand.deviceRotation.ReadValue();

            right.localPosition = rightPosition;
            right.localRotation = rightRotation;
        }

        XRHMD hmd = InputSystem.GetDevice<XRHMD>();

        if (hmd != null)
        {
            Vector3 headPosition = hmd.devicePosition.ReadValue();
            Quaternion headRotation = hmd.deviceRotation.ReadValue();

            head.localPosition = headPosition;
            head.localRotation = headRotation;
        }
    }
}