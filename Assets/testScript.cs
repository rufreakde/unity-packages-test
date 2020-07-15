using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    [InfoBox("TODO: -Fix Manager System so it can be used smoothly on new setups!")]
    [Slider(0.1f,2.0f)]
    [SerializeField]
    private float scaleOfSprite = 1.0f;

    public float ScaleOfSprite
    {
        get {
            return scaleOfSprite;
        }
        set {
            scaleOfSprite = value;
            this.transform.localScale = new Vector3(value, value, value);
        }
    }
   
}
