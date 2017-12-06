//基本功能
//选择摄像头采集或者打开文件
//出错弹出error
问题是不同的功能需要输入的项不同，只写了一个输入窗口，用户不知道什么功能应该输入什么，还会出现空余的textbox；或者也没有实现动态输入
解决：1.多个输入窗口，不同按钮弹出对应的输入窗口
2.一个输入窗口动态输入


FaceIdentify gid				1
FaceVerify uid gid				2
FaceRegister uid gid uinfo			3
FaceUpdate uid gid uinfo			3
FaceDelete uid gid				2
UserInfo uid					1
GroupUsers gid					1
GroupAddUser toGroupId uid fromGroupId		3
GroupDeleteUser uid gid				2

三个input窗口，用textbox代替label显示需要输入的信息，这个信息为全局变量，在主界面按钮事件里赋值，这样每个input只返回str1 或 str1 str2 或 str1 str2 str3，相应功能函数里进行赋值
最后需要修改主界面按钮窗口的相应input窗口调用，注意groupadduser
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
app 所有全局变量定义 所有人脸操作函数定义
window_camera 摄像头取材保存，每次覆盖
window_select 选择图片输入方式
_1_input _2input 3_input 文本信息输入