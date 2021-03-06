﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Miaow.Infrastructure.Crosscutting.Authorize
{
    public interface IUserService
    {
        #region add user

        /// <summary>
        /// 用于在用户面板添加没有Role的User
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userRole"></param>
        /// <param name="operUser"></param>
        /// <returns></returns>
        bool Add(Miaow.Infrastructure.Data.DataSys.Sys_AdminUser entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        bool Add(IList<Miaow.Infrastructure.Data.DataSys.Sys_AdminUser> entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Regsters the user.
        /// </summary>
        /// <param name="entity">The user.</param>
        /// <param name="userRole">The user role.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool Add(Miaow.Infrastructure.Data.DataSys.Sys_AdminUser entity, Miaow.Infrastructure.Data.DataSys.Sys_UserRoles userRole, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        bool Add(IList<Miaow.Infrastructure.Data.DataSys.Sys_AdminUser> entity, Miaow.Infrastructure.Data.DataSys.Sys_UserRoles userRole, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        #endregion

        #region delete

        #region delete

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="entity">The user.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool Delete(Miaow.Infrastructure.Data.DataSys.Sys_AdminUser entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        bool Delete(IList<Miaow.Infrastructure.Data.DataSys.Sys_AdminUser> entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        bool Delete(IList<int> idList, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the user by id.
        /// 只设置为不可用
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteById(int id, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the name of the user by.
        /// 只设置为不可用
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteByName(string name, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the name of the user by.
        /// 只设置为不可用
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteByEmail(string email, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the name of the user by.
        /// 只设置为不可用
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteByUserGuid(string guid, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);


        #endregion

        #region delete true

        bool DeleteTrue(Miaow.Infrastructure.Data.DataSys.Sys_AdminUser entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        bool DeleteTrue(IList<Miaow.Infrastructure.Data.DataSys.Sys_AdminUser> entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        bool DeleteTrue(IList<int> idList, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the user true by id.
        /// 物理删除
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteTrueById(int id, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the name of the user true by.
        /// 物理删除
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteTrueByName(string name, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the name of the user true by.
        /// 物理删除
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteTrueByEmail(string email, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Deletes the name of the user true by.
        /// 物理删除
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool DeleteTrueByUserGuid(string guid, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        #endregion

        #endregion

        #region modify

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="entity">The user.</param>
        /// <param name="operUser">The oper user.</param>
        /// <returns></returns>
        bool Modify(Miaow.Infrastructure.Data.DataSys.Sys_AdminUser entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        bool Modify(IList<Miaow.Infrastructure.Data.DataSys.Sys_AdminUser> entity, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Users the change PWD by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        bool ModifyPwdById(int id, string pwd, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        /// <summary>
        /// Users the name of the change PWD by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        bool ModifyPwdByName(string name, string pwd, Miaow.Infrastructure.Data.DataSys.Sys_AdminUser operUser);

        #endregion

        #region get user model

        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser Get(int id);

        IQueryable<Miaow.Infrastructure.Data.DataSys.Sys_AdminUser> GetList();

        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetDefaultOperUser();
       
        /// <summary>
        /// Gets the user model by user name and PWD.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetUserByUserAndPwd(string name, string pwd);

        /// <summary>
        /// Gets the name of the user model by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetUserByName(string name);

        /// <summary>
        /// Gets the name of the user model by.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetUserById(int id);

        /// <summary>
        /// Gets the user model by email.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetUserByEmail(string email);

        /// <summary>
        /// Gets the user model by QQ.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetUserByQQ(string qqId);

        /// <summary>
        /// Gets the user model by sina.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetUserBySina(string sinaId);

        /// <summary>
        /// Gets the user model by user GUID.
        /// </summary>
        /// <param name="guid">The GUID.</param>
        /// <returns></returns>
        Miaow.Infrastructure.Data.DataSys.Sys_AdminUser GetUserByUserGuid(string guid);

        #endregion

        #region exist user

        /// <summary>
        /// Exists the name of the user by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        bool ExistUserByName(string name);

        /// <summary>
        /// Exists the name of the user by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        bool ExistUserByEmail(string email);

        /// <summary>
        /// Exists the user by name PWD.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pwd">The PWD.</param>
        /// <param name="login">if set to <c>true</c> [login].</param>
        /// <returns></returns>
        bool ExistUserByNamePwd(string name, string pwd, bool login);

        /// <summary>
        /// Exists the user by name PWD no MD5.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pwd">The PWD.</param>
        /// <returns></returns>
        bool ExistUserByNamePwdEncrypted(string name, string pwd);


        #endregion

        #region other
        
        /// <summary>
        /// Gets the user name by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        string GetUserNameById(int id);

        /// <summary>
        /// Gets the name of the user id by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        int GetUserIdByName(string name);

        /// <summary>
        /// 添加用户前的存在判断
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        bool UserHasUser(string username, string email);

        #endregion

    }
}
