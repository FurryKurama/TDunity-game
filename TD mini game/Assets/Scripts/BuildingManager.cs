using UnityEngine;

public class BuildingManager : MonoBehaviour 
{

    private Camera mainCamera;
    private BuildingTypeList buildingTypeList;
    private BuildingTypeSO buildingType;

    private void Start()
    {
        mainCamera = Camera.main;
        buildingTypeList = Resources.Load<BuildingTypeList>(nameof(BuildingTypeList));
        buildingType = buildingTypeList.list[0];
    }

    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(buildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            buildingType = buildingTypeList.list[0];
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            buildingType = buildingTypeList.list[1];
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 getMouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        getMouseWorldPosition.z = 0f;
        return getMouseWorldPosition;
    }

}
