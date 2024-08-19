using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBase : MonoBehaviour
{
    private void OnEnable()
    {
        transform.localPosition = Vector3.zero;
    }
    
    void Update()
    {
        if (!GD_GameManager.Instance.isPlaying) return;
        transform.Translate(Vector3.left * (Time.deltaTime * GD_GameManager.Instance.gameSpeed));

        if (transform.position.x < -10)
        {
            gameObject.SetActive(false);
        }
    }
}
