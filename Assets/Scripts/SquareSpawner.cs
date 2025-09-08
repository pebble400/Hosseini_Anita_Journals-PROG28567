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
        Vector2 scale = prefab.transform.localScale;
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab, mouse, Quaternion.identity);
        }
        scale += new Vector2(0.1f, 0.1f) * Input.mouseScrollDelta.y;
        prefab.transform.localScale = scale;
        Debug.Log(Input.mouseScrollDelta);
    }
}
