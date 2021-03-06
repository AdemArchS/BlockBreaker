using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    GameSession theGameSession;
    Ball theBall;

    private void Start()
    {
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
    }

    void Update()
    {
        Vector2 paddlePos = new Vector2 (Mathf.Clamp(GetXPos(), minX, maxX), transform.position.y);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        if(theGameSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
