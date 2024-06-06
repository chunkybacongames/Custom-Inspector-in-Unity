using UnityEditor;

[CustomEditor(typeof(PlayerScript))]
public class PlayerEditorScript : Editor
{
    #region Variables

    private SerializedProperty _jumpProperty;
    private SerializedProperty _jumpPowerProperty;
    private SerializedProperty _healthProperty;
    private SerializedProperty _attackPowerProperty;

    #endregion

    private void OnEnable()
    {
        _jumpProperty = serializedObject.FindProperty("jump");
        _jumpPowerProperty = serializedObject.FindProperty("jumpPower");
        _healthProperty = serializedObject.FindProperty("health");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(_jumpProperty);

        if (_jumpProperty.boolValue)
        {
            EditorGUILayout.PropertyField(_jumpPowerProperty);
        }

        EditorGUILayout.PropertyField(_healthProperty);

        serializedObject.ApplyModifiedProperties();
    }
}
