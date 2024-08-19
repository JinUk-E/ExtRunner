using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public SpriteRenderer[] groundSprites;
    public Sprite[] groundSprite;
    private SpriteRenderer tempSpriteRenderer;
    void Start()
    {
        tempSpriteRenderer = groundSprites[0];
    }
    
    void Update()
    {
        if(GD_GameManager.Instance.isPlaying == false) return;
        for (var i = 0; i < groundSprites.Length; i++)
        {
            if(-8 >= groundSprites[i].transform.position.x)
            {
                for (var q = 0; q < groundSprites.Length; q++)
                {
                    if(tempSpriteRenderer.transform.position.x < groundSprites[q].transform.position.x)
                    {
                        tempSpriteRenderer = groundSprites[q];
                    }
                }
                groundSprites[i].transform.position = new Vector3(tempSpriteRenderer.transform.position.x + 1, groundSprites[i].transform.position.y, groundSprites[i].transform.position.z);
                groundSprites[i].sprite = groundSprite[Random.Range(0, groundSprite.Length)];
            }
        }

        foreach (var sr in groundSprites)
        {
            sr.transform.Translate(Vector3.left * (GD_GameManager.Instance.gameSpeed * Time.deltaTime));
        }
    }
}
