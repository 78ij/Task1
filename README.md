主线任务
* 用Unity (或者其他引擎)编写一个炮台打飞机游戏。
* 主要目标：
   1. 实现飞机的对象池，飞机随机出现，游戏中最多存在50架(或其它合理数量)飞机。
   2. 实现多种类型的飞机，用到“抽象类”，“接口”。
   3. 游戏结构完整，包含开始游戏和退出游戏的功能，并有胜利与失败判定。
   4. 使用到工厂模式。
   6. 使用Github进行代码管理。
   
支线任务

* 使用 Unity3D 引擎完成主线任务.

* 在你的打飞机游戏中, 实现一种方案, 使得游戏中某一类物体的各项非动态非实时的属性 (比如飞机的最大血量和攻击力) 能够在`某一个物体(而不是所有已生成物体)`的`Inspector`里直接修改, 在游戏运行时`(Debug Run)`立即 生效.
 
  提示:
  可以使用设计模式中的原型模式 (Prototype) 观察者模式 (Observer).
  尽管不是很推荐, 但是你可以使用单例模式 (Singleton) 和 原型模式 (Prototype).
  实现这一功能不需要写编辑器扩展.
  熟练使用 C# 提供的 property 语法糖.

* 通读 Box2D 用户手册 (user manual) . 思考如何将其整合进 Unity3D.
  
  提示:
  C# 语言本身提供一种机制, 可以导入由 C++ 代码生成的dll. 另外, Box2D 有一个 C# 绑定. Box2D的各种语言绑定参见 此链接.