using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int hitsTobreak;
    public Sprite hitSprite1;
    public Sprite hitSprite2;
    // Start is called before the first frame update

    public void HitsToBreak()
    {
        hitsTobreak--;
        if(hitsTobreak == 2)
            GetComponent<SpriteRenderer>().sprite = hitSprite1; 
        if(hitsTobreak == 1)
            GetComponent<SpriteRenderer>().sprite = hitSprite2;

    }
}
