# 版本变更情况

变更情况只记录主版本和次版本变化。版本号严格按照以下情况进行变更：

- 当版本出现了与上一版本不兼容的情况，将变更主版本号
- 当版本兼容上一版本，将变更次版本号

兼容，即升级不需要变更任何代码便可以编译通过。

对于修订号和构建号此列表将不会记录，直接升级没有影响。

## 1.1

[#12](https://github.com/Newbe36524/Newbe.Mahua.Framework/issues/12) 提供对群列表、群成员列表的结构化接口支持

`IMahuaApi`新增方法:`GetGroupMemebersWithModel`,`GetGroupsWithModel`

## 1.0

主框架发布，支持CQP和Amanda机器人平台。
