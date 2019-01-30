Windows PowerShell
版权所有 (C) Microsoft Corporation。保留所有权利。

PS E:\GitHub\DDDgPractice\VSCodeInit\BooksApi> dotnet run
从 E:\GitHub\DDDgPractice\VSCodeInit\BooksApi\Properties\launchSettings.json 使用启动设置...
info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[0]
      User profile is available. Using 'C:\Users\PowerDGTMS\AppData\Local\ASP.NET\DataProtection-Keys' as key repository and Windows DPAPI to encrypt keys at rest.
Hosting environment: Development
Content root path: E:\GitHub\DDDgPractice\VSCodeInit\BooksApi
Now listening on: https://localhost:5001
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
      Request starting HTTP/1.1 GET http://localhost:5000/
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
      Request finished in 54.313ms 307
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
      Request starting HTTP/1.1 GET http://localhost:5000/
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
      Request finished in 0.4349ms 307
info: Microsoft.AspNetCore.Server.Kestrel[20]
      Connection id "0HLK6DN9JO0F8" request processing ended abnormally.
System.IO.IOException: The decryption operation failed, see inner exception. ---> System.ComponentModel.Win32Exception: 处理证书时，出现了一个未知错误。
   --- End of inner exception stack trace ---
   at System.Net.Security.SslStreamInternal.ReadAsyncInternal[TReadAdapter](TReadAdapter adapter, Memory`1 buffer)
   at Microsoft.AspNetCore.Server.Kestrel.Core.Adapter.Internal.AdaptedPipeline.ReadInputAsync(Stream stream)
   at System.IO.Pipelines.PipeCompletion.ThrowLatchedException()
   at System.IO.Pipelines.Pipe.GetReadResult(ReadResult& result)
   at System.IO.Pipelines.Pipe.GetReadAsyncResult()
   at System.IO.Pipelines.Pipe.DefaultPipeReader.GetResult(Int16 token)
   at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequests[TContext](IHttpApplication`1 application)
   at Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol.ProcessRequestsAsync[TContext](IHttpApplication`1 application)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.PartialFrameCallback(AsyncProtocolRequest asyncRequest)
--- End of stack trace from previous location where exception was thrown ---
   at System.Net.Security.SslState.ThrowIfExceptional()
   at System.Net.Security.SslState.InternalEndProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslState.EndProcessAuthentication(IAsyncResult result)
   at System.Net.Security.SslStream.EndAuthenticateAsServer(IAsyncResult asyncResult)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_1(IAsyncResult iar)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.PartialFrameCallback(AsyncProtocolRequest asyncRequest)
--- End of stack trace from previous location where exception was thrown ---
   at System.Net.Security.SslState.ThrowIfExceptional()
   at System.Net.Security.SslState.InternalEndProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslState.EndProcessAuthentication(IAsyncResult result)
   at System.Net.Security.SslStream.EndAuthenticateAsServer(IAsyncResult asyncResult)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_1(IAsyncResult iar)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.PartialFrameCallback(AsyncProtocolRequest asyncRequest)
--- End of stack trace from previous location where exception was thrown ---
   at System.Net.Security.SslState.ThrowIfExceptional()
   at System.Net.Security.SslState.InternalEndProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslState.EndProcessAuthentication(IAsyncResult result)
   at System.Net.Security.SslStream.EndAuthenticateAsServer(IAsyncResult asyncResult)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_1(IAsyncResult iar)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
      Request starting HTTP/1.1 GET http://localhost:5000/api/books
info: Microsoft.AspNetCore.Hosting.Internal.WebHost[2]
      Request finished in 0.1481ms 307
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.PartialFrameCallback(AsyncProtocolRequest asyncRequest)
--- End of stack trace from previous location where exception was thrown ---
   at System.Net.Security.SslState.ThrowIfExceptional()
   at System.Net.Security.SslState.InternalEndProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslState.EndProcessAuthentication(IAsyncResult result)
   at System.Net.Security.SslStream.EndAuthenticateAsServer(IAsyncResult asyncResult)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_1(IAsyncResult iar)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.PartialFrameCallback(AsyncProtocolRequest asyncRequest)
--- End of stack trace from previous location where exception was thrown ---
   at System.Net.Security.SslState.ThrowIfExceptional()
   at System.Net.Security.SslState.InternalEndProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslState.EndProcessAuthentication(IAsyncResult result)
   at System.Net.Security.SslStream.EndAuthenticateAsServer(IAsyncResult asyncResult)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_1(IAsyncResult iar)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)
dbug: HttpsConnectionAdapter[1]
      Failed to authenticate HTTPS connection.
System.IO.IOException: The handshake failed due to an unexpected packet format.
   at System.Net.Security.SslState.StartReadFrame(Byte[] buffer, Int32 readBytes, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.StartReceiveBlob(Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ForceAuthentication(Boolean receiveFirst, Byte[] buffer, AsyncProtocolRequest asyncRequest)
   at System.Net.Security.SslState.ProcessAuthentication(LazyAsyncResult lazyResult)
   at System.Net.Security.SslStream.BeginAuthenticateAsServer(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken, AsyncCallback asyncCallback, Object asyncState)
   at System.Net.Security.SslStream.<>c.<AuthenticateAsServerAsync>b__51_0(SslServerAuthenticationOptions arg1, CancellationToken arg2, AsyncCallback callback, Object state)
   at System.Threading.Tasks.TaskFactory`1.FromAsyncImpl[TArg1,TArg2](Func`5 beginMethod, Func`2 endFunction, Action`1 endAction, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
   at System.Threading.Tasks.TaskFactory.FromAsync[TArg1,TArg2](Func`5 beginMethod, Action`1 endMethod, TArg1 arg1, TArg2 arg2, Object state)
   at System.Net.Security.SslStream.AuthenticateAsServerAsync(SslServerAuthenticationOptions sslServerAuthenticationOptions, CancellationToken cancellationToken)
   at Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionAdapter.InnerOnConnectionAsync(ConnectionAdapterContext context)