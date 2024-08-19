using System;
using UniRx;
using UnityEngine;

public class MovePresenter : MonoBehaviour
{
   private void OnEnable()
   {
      Observable.Interval(TimeSpan.FromSeconds(1))
         .Subscribe(_ => transform.position += Vector3.left * GameManager.Instance.WorldSpeed)
         .AddTo(this);
   }

}
