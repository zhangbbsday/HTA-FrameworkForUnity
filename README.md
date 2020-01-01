# HTA-FrameworkForUnity
HTA-Framework is a simple framework for Unity.

> 这是我学习和使用 Unity 中，总结出的，可以复用的内容。

## 导入

你可以将 ```HTAFramework``` 文件夹放置在你的 ```Assets``` 资源目录下。

## 内容

目前仅包含 ```UIFramework``` ，以后会有时间会不断补充。

### UIFramework

其中包含了一种简单的 UI 框架，可以实现 UI 的获取与储存、栈菜单和 UI 事件处理。

#### 使用

1. 通过 Unity 编辑器完成 UI 界面的布局。
2. 创建一个空白物体，添加 ```UIManager``` 组件。
3. 将 UI 界面物体绑定在```UIManager``` 组件上，并指定选择 UI 的 tag（不指定则全选择）。
4. 现在可以在代码中查找和使用 UI 了！

你可以通过 ```UIFramework\Example``` 查看示例。

> 注意：目前对重名 UI 的处理不是很好，需要对 UI 物体名称中加入数字，以区别不同的 UI 。

## 其他

具体文档之后有时间会制作。

