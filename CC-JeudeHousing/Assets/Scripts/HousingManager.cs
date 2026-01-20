using UnityEngine;

public class HousingManager : MonoBehaviour
{
    [Header("Objets à construire")]
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

    private GameObject objectToSpawn;

    public void SelectCube()
    {
        objectToSpawn = cubePrefab;
        Debug.Log("Cube selectionne !");
    }

    public void SelectSphere()
    {
        objectToSpawn = spherePrefab;
        Debug.Log("Sphere selectionnee !");
    }

    public void SelectCylinder()
    {
        objectToSpawn = cylinderPrefab;
        Debug.Log("Cylindre selectionne !");
    }

    public GameObject GetCurrentPrefab()
    {
        return objectToSpawn;
    }
}