using ScriptableFramework.Events;
using UnityEditor;
using UnityEngine;

namespace ScriptableFramework.Variables.UI.Editor
{
    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : GameEventEditorBase
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            GUI.enabled = Application.isPlaying;

            var e = target as GameEvent;

            if (GUILayout.Button("Raise"))
            {
                UnityEngine.Debug.Log("Raise");
                e.Raise();
            }
            DrawListeners();
        }
    }
}
 