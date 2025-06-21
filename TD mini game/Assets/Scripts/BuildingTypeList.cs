using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingTypeList", menuName = "ScriptableObj/BuildingTypeList")]
public class BuildingTypeList : ScriptableObject
{
    public List<BuildingTypeSO> list;
}
