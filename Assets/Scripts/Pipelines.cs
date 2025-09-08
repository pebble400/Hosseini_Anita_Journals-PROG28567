using UnityEngine;

public class Pipelines : MonoBehaviour
{
    public Vector3 storeMousePosition;
    public Vector3 storeMousePositionEnd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(storeMousePosition, storeMousePositionEnd);
        if (Input.GetMouseButtonUp(0))
        {
            storeMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Mouse Position:" + storeMousePosition);

        }
        if (Input.GetMouseButtonUp(1))
        {
            storeMousePositionEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Mouse Position:" + storeMousePositionEnd);
        }
    }
}
