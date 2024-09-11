using System;
using UnityEngine;

public class GroundPresenter : MonoBehaviour
{
      [field: SerializeField] public GroundModel GroundModel { get; set; }

      private void Start()
      {
          if (GroundModel == null) throw new NullReferenceException("GroundModel is null");
          if (GroundModel.GroundSprites.Count == 0) throw new NullReferenceException("GroundSprites is empty");
          
          for(var i = GroundModel.StartPoint.x; i< GroundModel.EndPoint.x; i++)
          {
              var ground = Instantiate(GroundModel.GroundPrefab, gameObject.transform, true);
              ground.transform.position = new Vector3(i, GroundModel.StartPoint.y, 0);
              ground.GetComponent<SpriteRenderer>().sprite = 
                  GroundModel.GroundSprites[UnityEngine.Random.Range(0, GroundModel.GroundSprites.Count)];
          }
          
      }
}
