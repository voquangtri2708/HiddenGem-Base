using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    public GameObject cellPrefab;
    public Transform gridPanel;
    public int totalCells = 12;

    void Start()
    {
        int indexHasGem = Random.Range(0, totalCells);

        for (int i = 0; i < totalCells; i++)
        {
            GameObject cell = Instantiate(cellPrefab, gridPanel);
            cell.name = "Cell_" + i;

            CellController controller = cell.GetComponent<CellController>();
            controller.hasGem = (i == indexHasGem); 
        }
    }
}


