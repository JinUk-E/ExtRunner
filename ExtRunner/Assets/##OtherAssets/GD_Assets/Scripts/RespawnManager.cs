using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RespawnManager : MonoBehaviour
{
    public List<GameObject> MobPool = new List<GameObject>();
    public GameObject[] Mobs;
    public int MobCount = 5;
    public GameObject MobParent;
    
    private void Awake()
    {
        foreach (var go in Mobs)
        {
            for (var j = 0; j < MobCount; j++)
            {
                MobPool.Add(CreateObject(go, transform));   
            }
        }
    }

    private void Start()
    {
        GD_GameManager.Instance.onPlay += StartRespawn;
    }

    private void StartRespawn(bool isPlaying)
    {
        if(isPlaying) StartCoroutine(CreateMob());
        else
        {
            StopCoroutine(CreateMob());
            MobPool.ForEach(mob => mob.SetActive(false));
        }
    }

    private IEnumerator CreateMob()
    {
        yield return new WaitForSeconds(0.5f);
        while (GD_GameManager.Instance.isPlaying)
        {
            var currentMob = MobPool[DeactivateMob()];
            currentMob.transform.SetParent(MobParent.transform);
            currentMob.transform.localPosition = Vector3.zero;
            currentMob.SetActive(true);
            yield return new WaitForSeconds(Random.Range(2f, 4f));   
        }
    }
    
    private int DeactivateMob()
    {
        for (var i = 0; i < MobPool.Count; i++)
        {
            if (!MobPool[i].activeSelf) return i;
        }

        return -1;
    }

    private GameObject CreateObject(GameObject obj, Transform parent)
    {
        var mob = Instantiate(obj, parent);
        mob.SetActive(false);
        MobPool.Add(mob);
        return mob;
    }
}
