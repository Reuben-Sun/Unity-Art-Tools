# Unity Art Tools

### 功能特色

[Readme](https://github.com/Reuben-Sun/Unity-Art-Tools/blob/main/DCCStudy/Packages/com.reuben.art-tools/README.md#reuebn-art-tools)

### 安装指南

打开Unity Package Manager，输入

```
https://github.com/Reuben-Sun/Unity-Art-Tools.git#upm
```

### 开发指南

#### 开发环境

Unity 版本2021.3.6f1c1 Window

#### 提交方法

1. 在`master`分支进行开发测试
   - 提交前请保证无编译错误，Runtime不崩溃，且无严重影响性能的功能
   - 请修改`package.json`的版本号
2. 提交`upm`分支，具体指令

```
git subtree split --prefix=DCCStudy/Packages/com.reuben.art-tools --branch upm
git tag 1.0.x upm
git push origin upm --tags
```

#### 其他教程

[Unity Package 开发入门](https://www.jianshu.com/p/153841d65846)

### 参考引用

本项目仅用于学习交流，不会进行任何商业用途

- Odin

