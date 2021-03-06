﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Miaow.Service.SSO.WebService.Models;

namespace Miaow.Service.SSO.WebService.Controllers
{
    [HandleError]
    public class RegisterController :
        Miaow.Infrastructure.Crosscutting.NetFramework.Controllers.MiaowBaseController
    {
        Miaow.Infrastructure.Crosscutting.Authorize.IUserService userService;

        public RegisterController(Miaow.Infrastructure.Crosscutting.NetFramework.IWorkContext work,
            Miaow.Infrastructure.Crosscutting.Authorize.IUserService MiaowUserService)
            : base(work)
        {
            if (MiaowUserService == null)
            {
                throw new ArgumentNullException("userService is null");
            }
            userService = MiaowUserService;
        }

        /// <summary>
        /// register 用户注册    
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult index(RegisterModel model, string usertype)
        {
            //两个地方，系统的原有的权限
            //再一个就是mvc controller表里的权限
            //注册的上面有一个选择用户类型
            //用户类型在adminuser表里面，有大概的用户类型
            //注册用户表
            //分配权限
            Miaow.Infrastructure.Data.DataSys.Sys_AdminUser user = new Infrastructure.Data.DataSys.Sys_AdminUser();
            Miaow.Infrastructure.Data.DataSys.Sys_UserRoles userRole = new Infrastructure.Data.DataSys.Sys_UserRoles();
            Miaow.Infrastructure.Data.DataSys.Sys_AdminUser perUser = new Infrastructure.Data.DataSys.Sys_AdminUser();
            userRole.RoleID = Convert.ToInt32(GetUserType(usertype, userRole));
            user.password = model.Password;
            user.Email = model.Email;
            user.UserType = usertype;
            user.username = model.UserName;
            perUser.id = 1;
            userService.Add(user, userRole, perUser);
            if (user.id != 0)
            {
                var currentRegisterUserDto = AutoMapper.Mapper.Map<Miaow.Infrastructure.Data.DataSys.Sys_AdminUser, Miaow.Service.SSO.Entity.User>(user);
                if (currentRegisterUserDto.id > 0)
                {
                    //add session 这里的session用法，要和子站点统一，管理好时间
                    Miaow.Infrastructure.Crosscutting.Function.SessionHelper.Add(
                        Miaow.Infrastructure.Crosscutting.Comm.Service.ConstService.SessionNameCurrentUser,
                       currentRegisterUserDto, Miaow.Infrastructure.Crosscutting.Comm.Service.ConstService.SessionExpires);
                    //添加 Cookie 一边以其它业务网站能够访问
                    Miaow.Infrastructure.Crosscutting.Comm.Service.SsoService.SendSsoUserLoginedCookie();
                    //用户登录后返回的地址
                    currentRegisterUserDto.LoginDomain = "http://sso.Miaow.cn";
                    currentRegisterUserDto.LoginIpAddress = Miaow.Infrastructure.Crosscutting.Function.StringHelper.GetRealIP();
                    //添加到SsoUserList中
                    UserLogined(currentRegisterUserDto);   //用户已登录
                    ModelState.AddModelError("", "注册成功 哦！ 亲");
                }
                else
                {
                    ModelState.AddModelError("", "注册失败 哦！亲");
                }
            }
            else
            {
                ModelState.AddModelError("", "注册失败 哦！亲");
            }
            return View();
        }

        //根据用户注册选择的UserType累判断简称
        [NonAction]
        private string GetUserType(string userSelected, Miaow.Infrastructure.Data.DataSys.Sys_UserRoles userRole)
        {
            if (userSelected == null)
            {
                throw new ArgumentNullException("usertype is null");
            }
            else
            {
                switch (userSelected)
                {
                    case "jq":
                        userRole.RoleID = 4;
                        break;
                    case "jd":
                        userRole.RoleID = 5;
                        break;
                    case "sj":
                        userRole.RoleID = 6;
                        break;
                    case "lxs":
                        userRole.RoleID = 7;
                        break;
                    case "xl":
                        userRole.RoleID = 8;
                        break;
                    case "tx":
                        userRole.RoleID = 9;
                        break;
                }
            }
            return Convert.ToString(userRole.RoleID);
        }

        //添加到网络列表中
        [NonAction]
        private void UserLogined(Miaow.Service.SSO.Entity.User user)
        {
            #region user first login

            var tempOnlineUser = Miaow.Service.SSO.WebService.OnLineUserService
                 .OnLineUserList.Where(e => e.username == user.username && e.id == user.id)
                 .FirstOrDefault();

            if (tempOnlineUser == null)
            {
                var onlineUser = new Miaow.Service.SSO.Entity.OnlineUser()
                {
                    Activity = user.Activity,
                    DepartmentID = user.DepartmentID,
                    Email = user.Email,
                    EmployeeID = user.EmployeeID,
                    id = user.id,
                    lastloginip = user.lastloginip,
                    lastlogintime = user.lastlogintime,
                    LoginDomain = user.LoginDomain,
                    LoginIpAddress = user.LoginIpAddress,
                    LoginTime = System.DateTime.Now,
                    logintimes = user.logintimes,
                    password = user.password,
                    Phone = user.Phone,
                    roleid = user.roleid,
                    sex = user.sex,
                    style = user.style,
                    truename = user.truename,
                    UserGuid = user.UserGuid,
                    userid = user.userid,
                    username = user.username,
                    UserType = user.UserType
                };
                Miaow.Service.SSO.WebService.OnLineUserService.OnLineUserList.Add(onlineUser);
            }
            #endregion
        }
    }
}
