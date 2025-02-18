using UnityEngine;

public class Pacman : MonoBehavior {


    private Vector2 pos;

    private void Move(Vector2 mv){
        pos += mv;
    }

}
