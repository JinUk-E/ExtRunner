using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [field: SerializeField] public PlayerModel Model { get; private set; }
    [field: SerializeField] public GameObject PlayerPrefab { get; private set; }
    
    private void Awake()
    {
        var player = Instantiate(PlayerPrefab, Model.OriginPosition.position, Quaternion.identity);
        player.transform.SetParent(gameObject.transform);
    }
}
