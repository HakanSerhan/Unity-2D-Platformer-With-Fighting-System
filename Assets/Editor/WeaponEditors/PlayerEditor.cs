using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Player))]
public class PlayerEditor : Editor
{
    private Player player;
    
    public override void OnInspectorGUI()
    {
        
        DrawDefaultInspector();

        player = target as Player;
    }

}