using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 * author: Liangyue
 * time: 07/28/2023
 * desceiption: 脚本生命周期
 */

public class Lifecycle : MonoBehaviour
{
    // 序列化字段
    // 作用：编译器中显示私有变量
    [SerializeField]
    private int a;

    [HideInInspector]
    public int b;

    [Range(0, 100)]
    public int c;

    public static int d = 0;

    public Lifecycle()
    {
        // Debug.Log("constructor");
        // 不要在脚本中写构造函数，or异常
    }

    /*****************************************
     * 脚本的生命周期
     * ***************************************/

    /**************初始化**********************/
    /**
     * * 时机：创建游戏对象，立即执行 （早于start）
     * 作用：初始化
     */
    private void Awake()
    {
        Debug.Log("name" + this.name + d++);
    }

    /**
     * 时机：创建游戏对象，脚本启用，才执行
     * 作用：初始化
     */
    private void Start()
    {

        int a = 1;
        int b = 2;
        int c = a + b;
        Debug.Log("time" + Time.time + "name" + this.name + d++);
    }

    /**
     * 时机：每当脚本启用时调用
     */
    private void OnEnable()
    {

    }

    /**************物理阶段**********************/

    /**
     * 执行时机：每隔固定时间被调用
     * 作用：适用于对游戏对象做物理操作，如移动，旋转，施加力等，不会受到渲染影响
     *
     */
    private void FixedUpdate()
    {
        /**
         * 多帧Debug：单帧调试
         * 1. 启动调试
         * 2. 运行场景
         * 3. 暂停游戏
         * 4. 加断点
         * 5. 单帧执行
         * 6. 结束调试
         **/
    }

    /**
     * 执行时机：渲染帧执行，执行间隔不固定
     * 作用：VR渲染差不多70，80帧左右，手游30，40左右
     * 处理游戏逻辑
     */
    private void Update()
    {

    }

    /**
     * 执行时机：延迟更新
     * lateUpdate与update在同一帧做，lateUpdate在update之后执行
     * 适用于跟随逻辑
     */
    private void LateUpdate()
    {

    }

    /**
     * 场景渲染
     * 物体被照相机可见时执行操作
     */
    private void OnBecameVisible()
    {

    }

    /**
     * 物体被照相机不可见时候执行操作
     */
    private void OnBecameInvisible()
    {

    }


}
