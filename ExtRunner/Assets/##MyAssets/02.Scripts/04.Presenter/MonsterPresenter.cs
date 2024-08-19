using System;
using UniRx;
using UnityEngine;
using Random = UnityEngine.Random;

public class MonsterPresenter : MonoBehaviour
{
    [field: SerializeField] public MonsterModel Model { get; set; }
    
    // 몬스터 풀에서 꺼내서 지정 위치로 이동시키고 활성화하는 함수
    private void SetMonster()
    {
        PoolingSystem.Instance.PoolCheck(Model.PoolList[Random.Range(0, Model.PoolList.Count-1)].name);
        var monster = PoolingSystem.Instance.
            GetObject(Model.PoolList[Random.Range(0, Model.PoolList.Count-1)].name, Model.SpawnPoint, 2);
        if(monster == null) return;
        monster.transform.localPosition = Vector3.zero;
        monster.SetActive(true);
    }
    
    private void Awake()
    {
        Observable
            .Interval(TimeSpan.
                FromSeconds(Random.Range(Model.SpawnInterval.x, Model.SpawnInterval.y)))
            .Subscribe(_ => SetMonster()).AddTo(this);
    }
}
