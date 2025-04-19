using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public GameObject cellPrefab;
    public Transform gridPanel;
    public int totalCells = 12; 

    void Start()
    {
        for (int i = 0; i < totalCells; i++)
        {
            Instantiate(cellPrefab, gridPanel);
        }
    }
}
