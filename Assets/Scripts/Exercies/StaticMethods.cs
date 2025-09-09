using UnityEngine;

public class StaticMethods : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 vec = new Vector2(10, 8);
        
        float magnitude = MethodExamples.GetMagnitude(vec);

        print($"This is inside Static Methods");
    }
}
