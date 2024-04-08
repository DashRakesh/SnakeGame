using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssetes : MonoBehaviour
{
    public static GameAssetes i;

    private void Awake()
    {
        i = this;
    }

    public Sprite snakeHeadSprite;
    public Sprite foodSprite;

}