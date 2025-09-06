using UnityEngine;

public class ScrollWheelScale : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 scale = transform.localScale;
        if(Input.mouseScrollDelta.y != 0)
        {
            Vector3 scale = transform.localScale;
        }
    }
}
