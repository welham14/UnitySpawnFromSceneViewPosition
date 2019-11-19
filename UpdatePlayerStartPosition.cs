using UnityEditor;

// ensure class initializer is called whenever scripts recompile
[InitializeOnLoadAttribute]

public static class UpdatePlayerStartPosition {

    // register an event handler when the class is initialized
    static UpdatePlayerStartPosition() {
        EditorApplication.playModeStateChanged += LogPlayModeState;
    }

    private static void LogPlayModeState(PlayModeStateChange state) {
        if (state == PlayModeStateChange.ExitingEditMode){
            GameDataScript.playerStartPos = SceneView.lastActiveSceneView.camera.transform.position;
        }
    }
}