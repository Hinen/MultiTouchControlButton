#if UNITY_EDITOR

using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(MultiTouchControlButton))]
public class MultiTouchControlButtonEditor : ButtonEditor {
    public override void OnInspectorGUI() {
        serializedObject.Update();

        MultiTouchControlButton button = (MultiTouchControlButton)target;
        button.multiTouchable = EditorGUILayout.Toggle("Multi Touchable", button.multiTouchable);

        base.OnInspectorGUI();

        serializedObject.ApplyModifiedProperties();
    }
}

#endif