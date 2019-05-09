# 05 配置启动mysql

 																				2018年09月28日 16:08:25 					[Burgess_Lee](https://me.csdn.net/Burgess_Lee) 						阅读数：51 			       					 							 					                   					 					版权声明：https://blog.csdn.net/Burgess_Lee		

https://blog.csdn.net/Burgess_Lee/article/details/82885191				

具体步骤可以参考：官方网站提供的操作步骤。

```html
https://hub.docker.com/_/mysql/
```

首先执行

```
docker pull mysql
```

通过docker images 可以查看对应的本地已经下载的[镜像](https://www.baidu.com/s?wd=%E9%95%9C%E5%83%8F&tn=24004469_oem_dg&rsv_dl=gh_pl_sl_csd)

```java
[root@localhost ~]# docker run --name mysql01 -d mysql



42f09819908bb72dd99ae19e792e0a5d03c48638421fa64cce5f8ba0f40f5846
 
mysql退出了
 

[root@localhost ~]# docker ps -a 

CONTAINER ID        IMAGE               COMMAND                  CREATED             STATUS                           PORTS               NAMES
 
42f09819908b        mysql               "docker-entrypoint.sh"   34 seconds ago      Exited (1) 33 seconds ago                            mysql01
 

538bde63e500        tomcat              "catalina.sh run"        About an hour ago   Exited (143) About an hour ago                       compassionate_ 
goldstine
 
c4f1ac60b3fc        tomcat              "catalina.sh run"        About an hour ago   Exited (143) About an hour ago                       lonely_fermi



81ec743a5271        tomcat              "catalina.sh run"        About an hour ago   Exited (143) About an hour ago                       sick_ramanujan

 


//错误日志



[root@localhost ~]# docker logs 42f09819908b



error: database is uninitialized and password option is not specified 



  You need to specify one of MYSQL_ROOT_PASSWORD, MYSQL_ALLOW_EMPTY_PASSWORD and MYSQL_RANDOM_ROOT_PASSWORD；这个三个参数必须指定一个
```

如果直接启动，会提示错误。显示需要制定额外的参数。于是，采用如下的方式进行启动操作。

![img](https://img-blog.csdn.net/20180928154710719?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0J1cmdlc3NfTGVl/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

如图启动成功。可以通过命令查看对应的启动的状态。如下图所示：

![img](https://img-blog.csdn.net/20180928154803465?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0J1cmdlc3NfTGVl/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

这里启动完成之后，并不能使用。因为没有将对应的3306端口和对应[服务器](https://www.baidu.com/s?wd=%E6%9C%8D%E5%8A%A1%E5%99%A8&tn=24004469_oem_dg&rsv_dl=gh_pl_sl_csd)上的3306进行绑定。所以不能使用。

使用docker stop 对应的id 停止对应的容器。如下图所示：

![img](https://img-blog.csdn.net/20180928155250788?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0J1cmdlc3NfTGVl/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

因此采用下面的命令进行启动。

![img](https://img-blog.csdn.net/20180928155712634?watermark/2/text/aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L0J1cmdlc3NfTGVl/font/5a6L5L2T/fontsize/400/fill/I0JBQkFCMA==/dissolve/70)

然后通过对应的数据库连接工具进行连接。

------

------

------

