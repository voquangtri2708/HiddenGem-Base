using UnityEngine;
using UnityEngine.UI;

public class CellController : MonoBehaviour
{
    private Image gemImage;

    public bool hasGem = false;

    private bool revealed = false;

    void Start()
    {
        gemImage = transform.Find("Gem").GetComponent<Image>();

        gemImage.enabled = false;

        GetComponent<Button>().onClick.AddListener(OnCellClick);
    }

    void OnCellClick()
    {
        if (revealed) return;

        revealed = true;

        if (hasGem)
        {
            gemImage.enabled = true;
            Debug.Log("You found the gem in: " + gameObject.name);
        }
        else
        {
            Debug.Log("No gem in: " + gameObject.name);
        }
    }
}
