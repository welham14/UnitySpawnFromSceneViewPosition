using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDataScript : MonoBehaviour{

    static public Vector3 playerStartPos;
    public Transform player;

    private void Start() {
        player.position = playerStartPos;
    }
}