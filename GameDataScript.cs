using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDataScript : MonoBehaviour{

    static public Vector3 playerStartPos;
    public Transform player;
    public bool autoUpdatePosition = true;

    private void Start() {
        if (autoUpdatePosition)
        player.position = playerStartPos;
    }
}