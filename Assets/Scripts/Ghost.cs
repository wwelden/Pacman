using UnityEngine;
using System;

public class Ghost : Entity
{
    public Vector2 Position;
    public float speed = 1;
    public int range = 5;
    public bool BlueMode = false;

    public void Update()
    {

    }

    public bool checkRange()
    {
        if (range > EclideanDistance(GameData.PACMANLoc, Position))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public Double EclideanDistance(Vector2 a, Vector2 b)
    {
        return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
    }

    public void Move(Vector2 movement)
    {
        transform.Translate(movement * speed * Time.deltaTime);
        Position += movement;
    }

    public void Follow()
    {
        if (checkRange())
        {
            double xDif = Position.x - GameData.PACMANLoc.x;
            double yDif = Position.y - GameData.PACMANLoc.y;
            float xMv = 0;
            float yMv = 0;
            if (xDif >= 0)
            {
                xMv = 1;
            }
            else
            {
                xMv = -1;
            }
            if (yDif >= 0)
            {
                yMv = 1;
            }
            else
            {
                yMv = -1;
            }
            Move(new Vector2(xMv, yMv));
        }

    }



}
