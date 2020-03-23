using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int hitsTobreak;
    public Sprite hitSprite;
    // Start is called before the first frame update

    public void HitsToBreak()
    {
        hitsTobreak--;
        GetComponent<SpriteRenderer>().sprite = hitSprite;        
    
    }
}
