using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RowGeneration : MonoBehaviour
{
    public GameObject generateSquare;
    public GameObject InputField;
    public int howManySquares = 4;
    bool squarenum;

    private void Update()
    {
        squarenum = int.TryParse(InputField.GetComponent<TMP_InputField>().text, out howManySquares);

        if (squarenum)
        {
            howManySquares = int.Parse(InputField.GetComponent<TMP_InputField>().text);
        }

    }
    public void Spawn()
    {
        for(int i = 0; i < howManySquares; i++)
        {
            GameObject newSquare = Instantiate(generateSquare);
            newSquare.transform.position = new Vector2(1 * i, 3);
        }
    }
}
