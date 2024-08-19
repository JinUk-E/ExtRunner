using RNBUtil;
using UnityEngine;

public class GroundPresenter : MonoBehaviour
{
    [field: SerializeField] public GroundModel Model { get; private set; }
    
    
    // 풀에서 지형을 꺼내서 배치하고 맨 뒤로 이동시키는 함수
    private void ActivateGround()
    {
        DebugerEx.Logger(gameObject.name, DebugerEx.DebugType.Log);
        // var groundObject = PoolingSystem.Instance.GetObject(gameObject.name, Model.StartPoint, 17);
        // groundObject.SetActive(true);
    }

    private void Start()
    {
        ActivateGround();
    }
}
