using UnityEngine;
using UnityEngine.UI;

public class CellBehavior : MonoBehaviour
{
    private Image gemImage;

    void Start()
    {
        gemImage = transform.Find("Gem").GetComponent<Image>();
        
        
        gemImage.enabled = false;
        
        GetComponent<Button>().onClick.AddListener(OnCellClick);
    }

    public void OnCellClick()
    {
        if (!gemImage.enabled)
        {
            gemImage.enabled = true; 
        }
    }
}
