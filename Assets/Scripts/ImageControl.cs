using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageControl : MonoBehaviour
{
    public enum State{ //the state that the ImageControl component is in affects behaviors of other objects
        normal, changeView
    };

    public State currentState {get; set;}
    
    public int nRoom = 3;
    public int CurrentRoom{ //public getter and setter of currentRoom
        get {return currentRoom;}
        set{
            if (value > nRoom) currentRoom = 1;
            else if (value <= 1) currentRoom = nRoom;
            else currentRoom = value;
        }
    }

    private int previousRoom;
    private int currentRoom;

    private SpriteRenderer sprite;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        previousRoom = 0;
        currentRoom = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentRoom != previousRoom){ //This is to prevent room from infinitely updating
            sprite.sprite = Resources.Load<Sprite>("RoomPics/room" + currentRoom.ToString());
        }

        previousRoom = currentRoom;
    }
}
