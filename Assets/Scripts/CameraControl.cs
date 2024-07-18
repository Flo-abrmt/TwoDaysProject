using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float panSpeed = 20f; // Speed of camera movement
    public float panBorderThickness = 10f; // Thickness of screen border to start moving
    public float zoomSpeed = 5f; // Speed of camera zoom
    public Vector2 panLimit; // Limit for panning

    private Vector3 dragOrigin;

    void Update()
    {
        Vector3 pos = transform.position;

        // Keyboard movement
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        // Mouse drag movement
        if (Input.GetMouseButtonDown(1))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 difference = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            pos -= difference * panSpeed;
            dragOrigin = Input.mousePosition;
        }

        // Zooming
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.z += scroll * zoomSpeed * 100f * Time.deltaTime;

        // Clamping the position
        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.y = Mathf.Clamp(pos.y, -panLimit.y, panLimit.y);

        transform.position = pos;
    }
}

