using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputRotation : MonoBehaviour
{
    public Vector2 turn;
    void start()
    {
        
    }

    void update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotaion = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
