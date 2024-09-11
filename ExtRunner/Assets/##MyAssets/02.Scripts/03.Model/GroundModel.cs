using System.Collections.Generic;
using UnityEngine;

public class GroundModel : MonoBehaviour
{
    [field: SerializeField] public List<Sprite> GroundSprites { get; set; }
    [field: SerializeField] public GameObject GroundPrefab { get; set; }
    [field: SerializeField] public Vector3 StartPoint { get; set; }
    [field: SerializeField] public Vector3 EndPoint { get; set; }
    
    
}
