using UnityEngine;
using System.Collections;

public class ShadowFollow : MonoBehaviour
{   
    private float shadowDist;
    private float shadowScale;
    public Transform charPos;

    void Update()
    {        
        shadowDist = charPos.transform.localPosition.y;
        Vector3 tmpPosition = transform.localPosition;
        tmpPosition.y = -shadowDist - 0.9f;
        transform.localPosition = tmpPosition;
        shadowScale = 1f - (shadowDist * 0.3f);        
        transform.localScale = new Vector3(shadowScale, shadowScale, shadowScale);
    }
}