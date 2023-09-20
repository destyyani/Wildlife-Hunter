using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] GameObject Player;
    PlayerController _controller;
    [Header("False for Left Button, True for Right Button")]
    [SerializeField] bool direction = false;
    bool pressed;
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (Player == null) {
            Player = GameObject.Find("Player") as GameObject;
        }
        _controller = Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed)
            _controller.moving(x);
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData){
        if (direction)
            x = 1;
        else
            x = -1;

        pressed=true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {
        x = 0;
        _controller.moving(x);
        pressed=false;
    }
}
