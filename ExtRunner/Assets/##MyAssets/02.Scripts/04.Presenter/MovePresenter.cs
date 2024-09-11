using System;
using UniRx;
using UnityEngine;

public class MovePresenter : MonoBehaviour
{
   private void OnEnable()
   {
      Observable.EveryUpdate()
         .Subscribe(_ => transform.position += Vector3.left * GameManager.Instance.WorldSpeed * Time.deltaTime)
         .AddTo(this);
   }

}
