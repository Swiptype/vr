using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public HousingManager housingManager;
    public InputActionProperty spawnAction;
    public float spawnDistance = 1.0f;

    private bool wasPressed = false; 

    void Update()
    {
        float triggerValue = spawnAction.action.ReadValue<float>();
        bool isPressed = triggerValue > 0.5f;

        if (isPressed && !wasPressed)
        {
            SpawnCurrentObject();
        }

        wasPressed = isPressed;
    }

    private void SpawnCurrentObject()
    {
        GameObject prefabToSpawn = housingManager.GetCurrentPrefab();

        if (prefabToSpawn != null)
        {
            Vector3 spawnPos = transform.position + (transform.forward * spawnDistance);
            
            Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
            
            Debug.Log("Objet cree : " + prefabToSpawn.name);
        }
        else
        {
            Debug.LogWarning("Aucun objet selectionne dans le menu !");
        }
    }
}