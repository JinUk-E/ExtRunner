using System;
using UniRx;
using UnityEngine;
using DG.Tweening;

public class PlayerPresenter : MonoBehaviour
{
    private PlayerSpawner _playerSpawner;
    private PlayerModel model;

    private void Awake()
    {
        _playerSpawner = FindObjectOfType<PlayerSpawner>();
        model = _playerSpawner.Model;
    }


    private void Start()
    {
        if (model == null) throw new NullReferenceException("PlayerModel is null");
        Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.Space)).Subscribe(_ =>
        {
            transform.DOMoveY(model.OriginPosition.position.y + model.JumpForce, model.JumpSpeed);
            transform.DOMoveY(model.OriginPosition.position.y, model.JumpSpeed);
        }).AddTo(this);
    }
}
