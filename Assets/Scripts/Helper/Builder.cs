//using UnityEngine;
//using UnityEngine.Tilemaps;

//public class Builder : MonoBehaviour
//{
//    public Tilemap tilemap;
//    public GameObject buildingPrefab; // Change this to GameObject to use prefab
//    public BuildManager buildManager;

//    private Building selectedBuilding;

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            Vector3Int cellPosition = tilemap.WorldToCell(mouseWorldPos);

//            if (selectedBuilding != null)
//            {
//                PlaceBuilding(cellPosition);
//            }
//        }
//    }

//    public void SelectBuilding(Building building)
//    {
//        selectedBuilding = building;
//    }

//    void PlaceBuilding(Vector3Int cellPosition)
//    {
//        GameObject newBuilding = Instantiate(buildingPrefab, tilemap.CellToWorld(cellPosition), Quaternion.identity);
//        newBuilding.GetComponent<SpriteRenderer>().sprite = selectedBuilding.GameSprite;
//    }
//}


//public class Builder : MonoBehaviour
//{
//    public Tilemap tilemap;
//    public GameObject buildingPrefab; // Prefab for building
//    public BuildManager buildManager;

//    private Building selectedBuilding;
//    private Camera mainCamera;

//    void Start()
//    {
//        // Ensure we have a reference to the main camera
//        mainCamera = Camera.main;
//        if (mainCamera == null)
//        {
//            Debug.LogError("Main Camera is not set or not tagged as 'MainCamera'.");
//            mainCamera = FindObjectOfType<Camera>(); // Fallback to any camera in the scene
//        }

//        if (mainCamera != null)
//        {
//            Debug.Log("Main Camera found: " + mainCamera.name);
//        }
//        else
//        {
//            Debug.LogError("No Camera found in the scene.");
//        }
//    }

//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0) && selectedBuilding != null)
//        {
//            Vector3? mouseWorldPos = GetMouseWorldPosition();
//            if (mouseWorldPos.HasValue)
//            {
//                Debug.Log($"Mouse World Position: {mouseWorldPos.Value}");

//                Vector3Int cellPosition = tilemap.WorldToCell(mouseWorldPos.Value);

//                PlaceBuilding(cellPosition);
//            }
//            else
//            {
//                Debug.LogError("Mouse World Position is null");
//            }
//        }
//    }

//    public void SelectBuilding(Building building)
//    {
//        selectedBuilding = building;
//    }

//    void PlaceBuilding(Vector3Int cellPosition)
//    {

//        if (selectedBuilding != null)
//        {
//            GameObject newBuilding = Instantiate(buildingPrefab, tilemap.CellToWorld(cellPosition), Quaternion.identity);
//            newBuilding.GetComponent<SpriteRenderer>().sprite = selectedBuilding.GameSprite;
//            buildManager.AddBuilding(selectedBuilding);
//            selectedBuilding = null; // Reset selected building after placing
//        }
//        else
//        {
//            Debug.LogError("Selected Building is null");
//        }
//    }

//    Vector3? GetMouseWorldPosition()
//    {
//        if (mainCamera == null)
//        {
//            Debug.LogError("Main Camera is not set.");
//            return null;
//        }

//        Vector3 mouseScreenPos = Input.mousePosition;
//        mouseScreenPos.z = mainCamera.nearClipPlane; // Ensure to set the z position

//        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(mouseScreenPos);
//        mouseWorldPos.z = 0; // Set z to 0 as we are working in 2D

//        return mouseWorldPos;
//    }
//}

using UnityEngine;
using UnityEngine.Tilemaps;

public class Builder : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject buildingPrefab; // Prefab for building
    public BuildManager buildManager;

    private Building selectedBuilding;
    private Camera mainCamera;

    void Start()
    {
        // Ensure we have a reference to the main camera
        mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main Camera is not set or not tagged as 'MainCamera'.");
            mainCamera = FindObjectOfType<Camera>(); // Fallback to any camera in the scene
        }

        if (mainCamera != null)
        {
            Debug.Log("Main Camera found: " + mainCamera.name);
        }
        else
        {
            Debug.LogError("No Camera found in the scene.");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && selectedBuilding != null)
        {
            Vector3? mouseWorldPos = GetMouseWorldPosition();
            if (mouseWorldPos.HasValue)
            {
                Debug.Log($"Mouse World Position: {mouseWorldPos.Value}");

                Vector3Int cellPosition = tilemap.WorldToCell(mouseWorldPos.Value);
                Debug.Log($"Cell Position: {cellPosition}");

                PlaceBuilding(cellPosition);
            }
            else
            {
                Debug.LogError("Mouse World Position is null");
            }
        }
    }

    public void SelectBuilding(Building building)
    {
        selectedBuilding = building;
    }

    void PlaceBuilding(Vector3Int cellPosition)
    {
        Vector3 worldPosition = tilemap.CellToWorld(cellPosition);
        Debug.Log($"Placing building at world position: {worldPosition}");

        GameObject newBuilding = Instantiate(buildingPrefab, worldPosition, Quaternion.identity);
        SpriteRenderer spriteRenderer = newBuilding.GetComponent<SpriteRenderer>();

        buildManager.PlaceBuilding(selectedBuilding);

        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = selectedBuilding.GameSprite;
            Debug.Log("Sprite set to building sprite.");
        }
        else
        {
            Debug.LogError("No SpriteRenderer found on building prefab.");
        }

        selectedBuilding = null; // Reset selected building after placing
    }

    Vector3? GetMouseWorldPosition()
    {
        if (mainCamera == null)
        {
            Debug.LogError("Main Camera is not set.");
            return null;
        }

        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = mainCamera.nearClipPlane; // Ensure to set the z position

        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(mouseScreenPos);
        mouseWorldPos.z = 0; // Set z to 0 as we are working in 2D

        return mouseWorldPos;
    }
}




// STAND BEFORE PLACING ::: BEFORE SECOND UPDATE
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Tilemaps;

//public class Builder : MonoBehaviour
//{
//    public BuildManager buildManager;
//    public Tilemap tilemap; // Reference to the Tilemap
//    public BuildingTile buildingTilePrefab; // Reference to the BuildingTile prefab

//    // Start is called before the first frame update
//    void Start()
//    {
//        // Example of creating a new building at runtime
//        //Building newBuilding = ScriptableObject.CreateInstance<Building>();
//        //newBuilding.name = "New Farm";
//        //newBuilding.ProduceAmountFood = 10;

//        // Add the new building to the BuildManager 
//        //buildManager.AddBuilding(newBuilding);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0)) // Left mouse button to place a building
//        {
//            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            Vector3Int cellPos = tilemap.WorldToCell(mouseWorldPos);
//            PlaceBuilding(cellPos);
//        }
//    }

//    public void PlaceBuilding(Vector3Int cellPosition)
//    {
//        BuildingTile newTile = Instantiate(buildingTilePrefab);
//        // Assign the Building ScriptableObject to the new tile
//        newTile.building = buildManager.GetBuildingToPlace(); // Assuming you have a method to get the building to place
//        tilemap.SetTile(cellPosition, newTile);
//    }
//}