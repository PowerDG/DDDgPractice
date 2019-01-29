



docker pull mysql

docker run -d -P mysql

docker ps -a 发现没有启动

启动加入

-e MYSQL_ROOT_PASSWORD=WSXwsx1001

 设置root用户密码

docker run -d -P -e MYSQL_ROOT_PASSWORD=root mysql



重命名容器名

sudo docker rename modest_goldberg mysql


sudo docker run --name myDg --link mysql:db -d mysql


然后连接至mysql



docker run 命令参数

-d 后台运行

-p 暴露端口

-e 设置环境变量，与在dockerfile env设置相同效果

--name 设置namne


https://hub.docker.com/_/mysql/

http://blog.csdn.net/wongson/article/details/49077353

---------------------
作者：芋智波佐助 
来源：CSDN 
原文：https://blog.csdn.net/u011686226/article/details/52815788 
版权声明：本文为博主原创文章，转载请附上博文链接！

---

简书 其他 Docker安装MySQL

https://www.jianshu.com/p/e453e173a6bb