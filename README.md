# Framework
MVVMLight框架
https://www.cnblogs.com/wzh2010/p/6285990.html

总是会带上ViewModelLocator类，并且生成资源字典并加入到了全局资源中。
所以每次App初始化的时候，就会去初始化ViewModelLocator类。

实际上他就是一个很基本的视图模型注入器。在构造器中把使用到的ViewModel统一注册，并生成单一实例。
然后使用属性把它暴露出来，每当我们访问属性的时候，就会返回相应的ViewModel实例。

https://www.cnblogs.com/wzh2010/p/6286923.html
即视图数据模型（ViewModel）和视图（View）之间的双向绑定和触发
