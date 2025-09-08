using UnityEngine;

public class Pipelines : MonoBehaviour
{
    public Vector3 storeMousePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            storeMousePosition = Input.mousePosition;
            Debug.Log("Mouse Position:" + storeMousePosition);
        }
    }
}
