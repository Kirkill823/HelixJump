
using UnityEngine;

public class control : MonoBehaviour
{
    public Transform Level;
    private Vector3 _previousMousePosition;
    public float sensetivity;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Level.Rotate(0, -delta.x * sensetivity, 0);
        }

        _previousMousePosition = Input.mousePosition;
    }
}
