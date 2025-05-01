using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Ghost PinkGhost;
    public Ghost RedGhost;
    public Ghost TealGhost;
    public Ghost OrangeGhost;
    public Pacman ThePacman;


    public void Start()
    {
        Instantiate(ThePacman, new Vector3(0, 0, 0), Quaternion.identity);
    }


}
