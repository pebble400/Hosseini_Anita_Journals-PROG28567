using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab, mouse, Quaternion.identity);
        }

    }
}
