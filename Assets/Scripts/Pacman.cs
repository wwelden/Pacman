using UnityEngine;

public class Pacman : MonoBehaviour
{
    public Vector3 Position;
    public float speed = 1;

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public Direction facingDirection = Direction.Right;

    void Update()
    {
        Movement();
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void Movement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            SetDirection(Direction.Up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            SetDirection(Direction.Down);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            SetDirection(Direction.Right);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            SetDirection(Direction.Left);
        }
    }

    public void SetDirection(Direction expected)
    {
        if (facingDirection != expected)
        {
            float angle = 0f;
            switch (expected)
            {
                case Direction.Up:
                    angle = 90f;
                    break;
                case Direction.Down:
                    angle = 270f;
                    break;
                case Direction.Left:
                    angle = 180f;
                    break;
                case Direction.Right:
                    angle = 0f;
                    break;
            }
            transform.rotation = Quaternion.Euler(0, 0, angle);
            facingDirection = expected;
        }

    }
}
