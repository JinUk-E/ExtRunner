using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReturn : MonoBehaviour
{
    [field: SerializeField] public GroundModel GroundModel { get; set; }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("PoolObject")) return;
        other.transform.position = new Vector3(GroundModel.EndPoint.x -1, GroundModel.StartPoint.y, 0);
        other.GetComponent<SpriteRenderer>().sprite = GroundModel.GroundSprites[Random.Range(0, GroundModel.GroundSprites.Count)];
    }
}
