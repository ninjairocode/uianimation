using UnityEngine;
using UnityEditor;

namespace Buttons.Car.Editor
{
    [CustomEditor(typeof(Car))]
    public class CarEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            //base.OnInspectorGUI();
            Car myTarget = (Car)target;
            
            myTarget.carPrefab = EditorGUILayout.ObjectField("Car Prefab", myTarget.carPrefab, typeof(GameObject), true) as GameObject;
            myTarget.speed = EditorGUILayout.IntField("Minha Velocidade", myTarget.speed);
            myTarget.gear = EditorGUILayout.IntField("Minha Marcha", myTarget.gear);
            
            EditorGUILayout.LabelField("Velocidade Total", myTarget.TotalSpeed.ToString());
            
            EditorGUILayout.HelpBox("Calcule a velocidade total do carro!", MessageType.Info);

            if (myTarget.TotalSpeed > 200)
            {
                EditorGUILayout.HelpBox("Velocidade acima do permitido", MessageType.Error);
            }
            
            GUI.color = Color.orange;
            if (GUILayout.Button("Create Car"))
            {
                myTarget.CreateCar();
            }
        }
    }
}
