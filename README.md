# Unity
### 1. Official Document
- Unity document: https://docs.unity.com/
- Unity 3D document: https://docs.unity3d.com/ScriptReference/
---
### 2. Unity3D 呈像
#### 2.1 渲染模型
1. Unity渲染模型都是从顶点(vertices)开始，顶点是由一组三维向量数组构成(Vector3[])，各个顶点的三维坐标分布在空间中。
2. 顶点赋值完毕后，开始生成三角面(triangles)，三角面是一组整形数组(int[])，其元素是顶点的三维向量数组的索引值，每三个元素构成一个三角面
#### 2.2 原理
- 偏振式3D成像是根据人眼成像原理发明的，人眼看到的景象呈现立体感，是由于双眼所观察到的景象有略微的差别，因为瞳距（两眼球之间的距离）导致观察的物体的角度不同。
- 所谓偏振成像就是将两幅不同偏振态的图像送到双眼，每只眼睛只允许看到其中一幅，我们用unity制作3D游戏，其实就是制作这两幅图像。或者说模拟3D信号。
---
### 3. 脚本生命周期
![image](https://github.com/Liangyue-1998/Csharp_learning/assets/61789633/063845a5-4de9-404a-8ad6-3295f3a67fd0)
---
### 4. 常用API
![image](https://github.com/Liangyue-1998/Csharp_learning/assets/61789633/72cbfa3b-21be-4a7e-a112-6eb999656bb2)




