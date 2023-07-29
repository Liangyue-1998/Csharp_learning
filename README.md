# Unity
### Official Document
- Unity document: https://docs.unity.com/
- Unity 3D document: https://docs.unity3d.com/ScriptReference/
### Unity3D 呈像原理
#### Unity渲染模型
1. Unity渲染模型都是从顶点(vertices)开始，顶点是由一组三维向量数组构成(Vector3[])，各个顶点的三维坐标分布在空间中。
2. 顶点赋值完毕后，开始生成三角面(triangles)，三角面是一组整形数组(int[])，其元素是顶点的三维向量数组的索引值，每三个元素构成一个三角面
