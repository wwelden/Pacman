using UnityEngine;

public class Pacman : MonoBehavior {
    private Vecotr2 pos;
    private void Move(Vector2 mv){
        pos += mv;
    }
    private void Update(){
        Movement();
    }
    private void Movement(){
        switch (true)
        {
            case bool _ when Input.GetKeyDown(KeyCode.W):
                Move(Vector2.up);
                break;
            case bool _ when Input.GetKeyDown(KeyCode.A):
                Move(Vector2.left);
                break;
            case bool _ when Input.GetKeyDown(KeyCode.S):
                Move(Vector2.down);
                break;
            case bool _ when Input.GetKeyDown(KeyCode.D):
                Move(Vector2.right);
                break;
        }
    }
}