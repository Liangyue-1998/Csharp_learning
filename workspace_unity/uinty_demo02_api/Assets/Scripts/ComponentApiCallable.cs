using Palmmedia.ReportGenerator.Core.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ----------------------------------------------------------------
// Author: Liangyue
// CreateTime: 7/20/2023
// ----------------------------------------------------------------

/**
 * Component 类提供了查找组件的功能
*/
public class ComponentApiCallable : MonoBehaviour 
{
    private GameObject cube;

    private Transform cubeTransform;

    private void Start()
    {
        // 查找物体并实例化
        this.transform.Find("Cube");
        GameObject[] gameObejctArray = GameObject.FindGameObjectsWithTag("cubeTag");
        GameObject gameObejct= GameObject.FindGameObjectWithTag("cubeTag");
        cube = GameObject.Find("Cube");
    }
    private void OnGUI()
    {
        /**
         * 给物体添加组件
         */
        if (GUILayout.Button("addComponent - light")) 
        {
            Light light = cube.AddComponent<Light>();
            light.color = Color.yellow;
            light.type = LightType.Point;
        }


        if (GUILayout.Button("setTransform")) 
        {
            Vector3 postionVec = cube.transform.position;
            Debug.Log("Cube position: " + postionVec);

            cube.transform.position = new Vector3(0, 0, 10);
            Vector3 transfedPostionVec = this.cubeTransform.position;
            Debug.Log("Transfered cube position: " + transfedPostionVec);
        }

        if (GUILayout.Button("setComponent"))
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        if (GUILayout.Button("getAllComponent"))
        {
            // 获取当前物体的所有组件
            var allComponent = this.GetComponents<MeshRenderer>();
            foreach (var item in allComponent)
            {
                Debug.Log(item.GetType());
            }
        }
    }
}
