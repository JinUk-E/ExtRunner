using System.Collections.Generic;
using UnityEngine;

public class MonsterModel : MonoBehaviour
{
    [field: SerializeField] public Vector2Int SpawnInterval { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }
    [field: SerializeField] public List<GameObject> PoolList { get; set; }
}
