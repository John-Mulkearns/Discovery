# Done 1.04
1. BaseContoller added
2. Account Controller added
simple AccountController with RegisterMethod
check for uniqueness of given user name





28 NOV 2021 
Windows PowerShell
Copyright (C) Microsoft Corporation. All rights reserved.

Try the new cross-platform PowerShell https://aka.ms/pscore6

PS C:\AngularPlus\dating> cd api
PS C:\AngularPlus\dating\api> dotnet run
Building...
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 5.0.7 initialized 'DataContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (40ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (51ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT 1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT OBJECT_ID(N'[__EFMigrationsHistory]');
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (23ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [MigrationId], [ProductVersion]
      FROM [__EFMigrationsHistory]
      ORDER BY [MigrationId];
info: Microsoft.EntityFrameworkCore.Migrations[20405]
      No migrations were applied. The database is already up to date.
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT CASE
          WHEN EXISTS (
              SELECT 1
              FROM [Users] AS [u]) THEN CAST(1 AS bit)
          ELSE CAST(0 AS bit)
      END
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT CASE
          WHEN EXISTS (
              SELECT 1
              FROM [Islands] AS [i]) THEN CAST(1 AS bit)
          ELSE CAST(0 AS bit)
      END
info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[63]
      User profile is available. Using 'C:\Users\webic\AppData\Local\ASP.NET\DataProtection-Keys' as key repository and Windows DPAPI to encrypt keys at rest.
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\AngularPlus\dating\api
info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 OPTIONS https://localhost:5001/api/account/login - -   
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 OPTIONS https://localhost:5001/api/account/login - - - 
204 - - 88.5437ms
info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 POST https://localhost:5001/api/account/login application/json 41
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
      Executing endpoint 'API.Controllers.AccountController.Login (API)'
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[3]
      Route matched with {action = "Login", controller = "Account"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[API.DTOs.UserDto]] Login(API.DTOs.LoginDto) on controller API.Controllers.AccountController (API).
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 5.0.7 initialized 'DataContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (50ms) [Parameters=[@__loginDto_Username_0='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[Id], [t].[City], [t].[Country], [t].[Created], [t].[DateOfBirth], [t].[Gender], [t].[Interests], [t].[Introduction], [t].[KnownAs], [t].[LastActive], [t].[LookingFor], [t].[PasswordHash], [t].[PasswordSalt], [t].[UserName], [p].[Id], [p].[AppUserId], [p].[IsMain], [p].[PublicId], [p].[Url]
      FROM (
          SELECT TOP(2) [u].[Id], [u].[City], [u].[Country], [u].[Created], [u].[DateOfBirth], [u].[Gender], [u].[Interests], [u].[Introduction], [u].[KnownAs], [u].[LastActive], [u].[LookingFor], [u].[PasswordHash], [u].[PasswordSalt], [u].[UserName]    
          FROM [Users] AS [u]
          WHERE [u].[UserName] = @__loginDto_Username_0
      ) AS [t]
      LEFT JOIN [Photos] AS [p] ON [t].[Id] = [p].[AppUserId]
      ORDER BY [t].[Id], [p].[Id]
info: Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor[1]
      Executing ObjectResult, writing value of type 'API.DTOs.UserDto'.
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[2]
      Executed action API.Controllers.AccountController.Login (API) in 964.9032ms    
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
      Executed endpoint 'API.Controllers.AccountController.Login (API)'
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 POST https://localhost:5001/api/account/login application/json 41 - 200 - application/json;+charset=utf-8 1086.8063ms
info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 OPTIONS https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=99&gender=female&orderBy=lastActive - -
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 OPTIONS https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=99&gender=female&orderBy=lastActive - - - 204 - - 4.5233msinfo: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 GET https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=99&gender=female&orderBy=lastActive - -
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerHandler[2]
      Successfully validated the token.
info: Microsoft.AspNetCore.Authorization.DefaultAuthorizationService[1]
      Authorization was successful.
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
      Executing endpoint 'API.Controllers.UsersController.GetUsers (API)'
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[3]
      Route matched with {action = "GetUsers", controller = "Users"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[System.Collections.Generic.IEnumerable`1[API.DTOs.MemberDto]]] GetUsers(API.Helpers.UserParams) on controller API.Controllers.UsersController (API).
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 5.0.7 initialized 'DataContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[@__username_0='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[Id], [t].[City], [t].[Country], [t].[Created], [t].[DateOfBirth], [t].[Gender], [t].[Interests], [t].[Introduction], [t].[KnownAs], [t].[LastActive], [t].[LookingFor], [t].[PasswordHash], [t].[PasswordSalt], [t].[UserName], [p].[Id], [p].[AppUserId], [p].[IsMain], [p].[PublicId], [p].[Url]
      FROM (
          SELECT TOP(2) [u].[Id], [u].[City], [u].[Country], [u].[Created], [u].[DateOfBirth], [u].[Gender], [u].[Interests], [u].[Introduction], [u].[KnownAs], [u].[LastActive], [u].[LookingFor], [u].[PasswordHash], [u].[PasswordSalt], [u].[UserName]    
          FROM [Users] AS [u]
          WHERE [u].[UserName] = @__username_0
      ) AS [t]
      LEFT JOIN [Photos] AS [p] ON [t].[Id] = [p].[AppUserId]
      ORDER BY [t].[Id], [p].[Id]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[@__userParams_CurrentUsername_0='?' (Size = 4000), @__userParams_Gender_1='?' (Size = 4000), @__minDob_2='?' (DbType = DateTime2), @__maxDob_3='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30'] 
      SELECT COUNT(*)
      FROM [Users] AS [u]
      WHERE ((([u].[UserName] <> @__userParams_CurrentUsername_0) OR [u].[UserName] IS NULL) AND ([u].[Gender] = @__userParams_Gender_1)) AND (([u].[DateOfBirth] >= @__minDob_2) AND ([u].[DateOfBirth] <= @__maxDob_3))
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (11ms) [Parameters=[@__userParams_CurrentUsername_0='?' (Size = 4000), @__userParams_Gender_1='?' (Size = 4000), @__minDob_2='?' (DbType = DateTime2), @__maxDob_3='?' (DbType = DateTime2), @__p_4='?' (DbType = Int32), @__p_5='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[DateOfBirth], [t].[City], [t].[Country], [t].[Created], [t].[Gender], [t].[Id], [t].[Interests], [t].[Introduction], [t].[KnownAs], [t].[LastActive], [t].[LookingFor], [t].[c], [t].[UserName], [p0].[Id], [p0].[IsMain], [p0].[Url]        
      FROM (
          SELECT [u].[DateOfBirth], [u].[City], [u].[Country], [u].[Created], [u].[Gender], [u].[Id], [u].[Interests], [u].[Introduction], [u].[KnownAs], [u].[LastActive], [u].[LookingFor], (
              SELECT TOP(1) [p].[Url]
              FROM [Photos] AS [p]
              WHERE ([u].[Id] = [p].[AppUserId]) AND ([p].[IsMain] = CAST(1 AS bit))) AS [c], [u].[UserName]
          FROM [Users] AS [u]
          WHERE ((([u].[UserName] <> @__userParams_CurrentUsername_0) OR [u].[UserName] IS NULL) AND ([u].[Gender] = @__userParams_Gender_1)) AND (([u].[DateOfBirth] >= @__minDob_2) AND ([u].[DateOfBirth] <= @__maxDob_3))
          ORDER BY [u].[LastActive] DESC
          OFFSET @__p_4 ROWS FETCH NEXT @__p_5 ROWS ONLY
      ) AS [t]
      LEFT JOIN [Photos] AS [p0] ON [t].[Id] = [p0].[AppUserId]
      ORDER BY [t].[LastActive] DESC, [t].[Id], [p0].[Id]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (7ms) [Parameters=[@p1='?' (DbType = Int32), @p0='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      UPDATE [Users] SET [LastActive] = @p0
      WHERE [Id] = @p1;
      SELECT @@ROWCOUNT;
info: Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor[1]
      Executing OkObjectResult, writing value of type 'API.Helpers.PagedList`1[[API.DTOs.MemberDto, API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]'.        
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[2]
      Executed action API.Controllers.UsersController.GetUsers (API) in 546.1204ms   
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
      Executed endpoint 'API.Controllers.UsersController.GetUsers (API)'
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 GET https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=99&gender=female&orderBy=lastActive - - - 200 - application/json;+charset=utf-8 706.5174ms
info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 OPTIONS https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=lastActive - -
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 OPTIONS https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=lastActive - - - 204 - - 0.4893msinfo: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 GET https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=lastActive - -
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerHandler[2]
      Successfully validated the token.
info: Microsoft.AspNetCore.Authorization.DefaultAuthorizationService[1]
      Authorization was successful.
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
      Executing endpoint 'API.Controllers.UsersController.GetUsers (API)'
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[3]
      Route matched with {action = "GetUsers", controller = "Users"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[System.Collections.Generic.IEnumerable`1[API.DTOs.MemberDto]]] GetUsers(API.Helpers.UserParams) on controller API.Controllers.UsersController (API).
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 5.0.7 initialized 'DataContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@__username_0='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[Id], [t].[City], [t].[Country], [t].[Created], [t].[DateOfBirth], [t].[Gender], [t].[Interests], [t].[Introduction], [t].[KnownAs], [t].[LastActive], [t].[LookingFor], [t].[PasswordHash], [t].[PasswordSalt], [t].[UserName], [p].[Id], [p].[AppUserId], [p].[IsMain], [p].[PublicId], [p].[Url]
      FROM (
          SELECT TOP(2) [u].[Id], [u].[City], [u].[Country], [u].[Created], [u].[DateOfBirth], [u].[Gender], [u].[Interests], [u].[Introduction], [u].[KnownAs], [u].[LastActive], [u].[LookingFor], [u].[PasswordHash], [u].[PasswordSalt], [u].[UserName]    
          FROM [Users] AS [u]
          WHERE [u].[UserName] = @__username_0
      ) AS [t]
      LEFT JOIN [Photos] AS [p] ON [t].[Id] = [p].[AppUserId]
      ORDER BY [t].[Id], [p].[Id]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@__userParams_CurrentUsername_0='?' (Size = 4000), @__userParams_Gender_1='?' (Size = 4000), @__minDob_2='?' (DbType = DateTime2), @__maxDob_3='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30'] 
      SELECT COUNT(*)
      FROM [Users] AS [u]
      WHERE ((([u].[UserName] <> @__userParams_CurrentUsername_0) OR [u].[UserName] IS NULL) AND ([u].[Gender] = @__userParams_Gender_1)) AND (([u].[DateOfBirth] >= @__minDob_2) AND ([u].[DateOfBirth] <= @__maxDob_3))
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[@__userParams_CurrentUsername_0='?' (Size = 4000), @__userParams_Gender_1='?' (Size = 4000), @__minDob_2='?' (DbType = DateTime2), @__maxDob_3='?' (DbType = DateTime2), @__p_4='?' (DbType = Int32), @__p_5='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[DateOfBirth], [t].[City], [t].[Country], [t].[Created], [t].[Gender], [t].[Id], [t].[Interests], [t].[Introduction], [t].[KnownAs], [t].[LastActive], [t].[LookingFor], [t].[c], [t].[UserName], [p0].[Id], [p0].[IsMain], [p0].[Url]        
      FROM (
          SELECT [u].[DateOfBirth], [u].[City], [u].[Country], [u].[Created], [u].[Gender], [u].[Id], [u].[Interests], [u].[Introduction], [u].[KnownAs], [u].[LastActive], [u].[LookingFor], (
              SELECT TOP(1) [p].[Url]
              FROM [Photos] AS [p]
              WHERE ([u].[Id] = [p].[AppUserId]) AND ([p].[IsMain] = CAST(1 AS bit))) AS [c], [u].[UserName]
          FROM [Users] AS [u]
          WHERE ((([u].[UserName] <> @__userParams_CurrentUsername_0) OR [u].[UserName] IS NULL) AND ([u].[Gender] = @__userParams_Gender_1)) AND (([u].[DateOfBirth] >= @__minDob_2) AND ([u].[DateOfBirth] <= @__maxDob_3))
          ORDER BY [u].[LastActive] DESC
          OFFSET @__p_4 ROWS FETCH NEXT @__p_5 ROWS ONLY
      ) AS [t]
      LEFT JOIN [Photos] AS [p0] ON [t].[Id] = [p0].[AppUserId]
      ORDER BY [t].[LastActive] DESC, [t].[Id], [p0].[Id]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@p1='?' (DbType = Int32), @p0='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      UPDATE [Users] SET [LastActive] = @p0
      WHERE [Id] = @p1;
      SELECT @@ROWCOUNT;
info: Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor[1]
      Executing OkObjectResult, writing value of type 'API.Helpers.PagedList`1[[API.DTOs.MemberDto, API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]'.
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[2]
      Executed action API.Controllers.UsersController.GetUsers (API) in 34.0861ms    
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
      Executed endpoint 'API.Controllers.UsersController.GetUsers (API)'
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 GET https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=lastActive - - - 200 - application/json;+charset=utf-8 42.6486ms
info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 OPTIONS https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=created - -
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 OPTIONS https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=created - - - 204 - - 1.0443ms   
info: Microsoft.AspNetCore.Hosting.Diagnostics[1]
      Request starting HTTP/2 GET https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=created - -
info: Microsoft.AspNetCore.Cors.Infrastructure.CorsService[4]
      CORS policy execution successful.
info: Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerHandler[2]
      Successfully validated the token.
info: Microsoft.AspNetCore.Authorization.DefaultAuthorizationService[1]
      Authorization was successful.
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[0]
      Executing endpoint 'API.Controllers.UsersController.GetUsers (API)'
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[3]
      Route matched with {action = "GetUsers", controller = "Users"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[System.Collections.Generic.IEnumerable`1[API.DTOs.MemberDto]]] GetUsers(API.Helpers.UserParams) on controller API.Controllers.UsersController (API).
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 5.0.7 initialized 'DataContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (11ms) [Parameters=[@__username_0='?' (Size = 4000)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[Id], [t].[City], [t].[Country], [t].[Created], [t].[DateOfBirth], [t].[Gender], [t].[Interests], [t].[Introduction], [t].[KnownAs], [t].[LastActive], [t].[LookingFor], [t].[PasswordHash], [t].[PasswordSalt], [t].[UserName], [p].[Id], [p].[AppUserId], [p].[IsMain], [p].[PublicId], [p].[Url]
      FROM (
          SELECT TOP(2) [u].[Id], [u].[City], [u].[Country], [u].[Created], [u].[DateOfBirth], [u].[Gender], [u].[Interests], [u].[Introduction], [u].[KnownAs], [u].[LastActive], [u].[LookingFor], [u].[PasswordHash], [u].[PasswordSalt], [u].[UserName]    
          FROM [Users] AS [u]
          WHERE [u].[UserName] = @__username_0
      ) AS [t]
      LEFT JOIN [Photos] AS [p] ON [t].[Id] = [p].[AppUserId]
      ORDER BY [t].[Id], [p].[Id]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (8ms) [Parameters=[@__userParams_CurrentUsername_0='?' (Size = 4000), @__userParams_Gender_1='?' (Size = 4000), @__minDob_2='?' (DbType = DateTime2), @__maxDob_3='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30'] 
      SELECT COUNT(*)
      FROM [Users] AS [u]
      WHERE ((([u].[UserName] <> @__userParams_CurrentUsername_0) OR [u].[UserName] IS NULL) AND ([u].[Gender] = @__userParams_Gender_1)) AND (([u].[DateOfBirth] >= @__minDob_2) AND ([u].[DateOfBirth] <= @__maxDob_3))
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (24ms) [Parameters=[@__userParams_CurrentUsername_0='?' (Size = 4000), @__userParams_Gender_1='?' (Size = 4000), @__minDob_2='?' (DbType = DateTime2), @__maxDob_3='?' (DbType = DateTime2), @__p_4='?' (DbType = Int32), @__p_5='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[DateOfBirth], [t].[City], [t].[Country], [t].[Created], [t].[Gender], [t].[Id], [t].[Interests], [t].[Introduction], [t].[KnownAs], [t].[LastActive], [t].[LookingFor], [t].[c], [t].[UserName], [p0].[Id], [p0].[IsMain], [p0].[Url]        
      FROM (
          SELECT [u].[DateOfBirth], [u].[City], [u].[Country], [u].[Created], [u].[Gender], [u].[Id], [u].[Interests], [u].[Introduction], [u].[KnownAs], [u].[LastActive], [u].[LookingFor], (
              SELECT TOP(1) [p].[Url]
              FROM [Photos] AS [p]
              WHERE ([u].[Id] = [p].[AppUserId]) AND ([p].[IsMain] = CAST(1 AS bit))) AS [c], [u].[UserName]
          FROM [Users] AS [u]
          WHERE ((([u].[UserName] <> @__userParams_CurrentUsername_0) OR [u].[UserName] IS NULL) AND ([u].[Gender] = @__userParams_Gender_1)) AND (([u].[DateOfBirth] >= @__minDob_2) AND ([u].[DateOfBirth] <= @__maxDob_3))
          ORDER BY [u].[Created] DESC
          OFFSET @__p_4 ROWS FETCH NEXT @__p_5 ROWS ONLY
      ) AS [t]
      LEFT JOIN [Photos] AS [p0] ON [t].[Id] = [p0].[AppUserId]
      ORDER BY [t].[Created] DESC, [t].[Id], [p0].[Id]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p1='?' (DbType = Int32), @p0='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      UPDATE [Users] SET [LastActive] = @p0
      WHERE [Id] = @p1;
      SELECT @@ROWCOUNT;
info: Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor[1]
      Executing OkObjectResult, writing value of type 'API.Helpers.PagedList`1[[API.DTOs.MemberDto, API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]'.        
info: Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker[2]
      Executed action API.Controllers.UsersController.GetUsers (API) in 97.4453ms    
info: Microsoft.AspNetCore.Routing.EndpointMiddleware[1]
      Executed endpoint 'API.Controllers.UsersController.GetUsers (API)'
info: Microsoft.AspNetCore.Hosting.Diagnostics[2]
      Request finished HTTP/2 GET https://localhost:5001/api/users?pageNumber=1&pageSize=5&minAge=18&maxAge=65&gender=female&orderBy=created - - - 200 - application/json;+charset=utf-8 101.4262ms









