//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace iPow.Domain.Dto
{
    using System.ComponentModel;
    using System.Runtime.Serialization;
    
    /// <summary>
    /// Sys_VideoInfo
    /// </summary>
    [Serializable]
    [DataContract]
    [FluentValidation.Attributes.Validator(typeof(Validate.Sys_VideoInfoDtoValidate))]
    public partial class Sys_VideoInfoDto
    {
        #region Primitive Properties
    
        /// <summary>
        /// 视频ID
        /// </summary>
    	[DataMember]
    	[DisplayName("视频ID")]
        public virtual int VideoID
        {
            get;
            set;
        }
    
        /// <summary>
        /// 景区ID
        /// </summary>
    	[DataMember]
    	[DisplayName("景区ID")]
        public virtual Nullable<int> SightID
        {
            get;
            set;
        }
    
        /// <summary>
        /// 视频名
        /// </summary>
    	[DataMember]
    	[DisplayName("视频名")]
        public virtual string VideoName
        {
            get;
            set;
        }
    
        /// <summary>
        /// 分类ID
        /// </summary>
    	[DataMember]
    	[DisplayName("分类ID")]
        public virtual int ClassID
        {
            get;
            set;
        }
    
        /// <summary>
        /// 说明
        /// </summary>
    	[DataMember]
    	[DisplayName("说明")]
        public virtual string Remark
        {
            get;
            set;
        }
    
        /// <summary>
        /// 播放次数
        /// </summary>
    	[DataMember]
    	[DisplayName("播放次数")]
        public virtual Nullable<int> PlayCount
        {
            get;
            set;
        }
    
        /// <summary>
        /// 标签
        /// </summary>
    	[DataMember]
    	[DisplayName("标签")]
        public virtual string Tag
        {
            get;
            set;
        }
    
        /// <summary>
        /// 视频文件名
        /// </summary>
    	[DataMember]
    	[DisplayName("视频文件名")]
        public virtual string VideoFile
        {
            get;
            set;
        }
    
        /// <summary>
        /// 视频URL地址
        /// </summary>
    	[DataMember]
    	[DisplayName("视频URL地址")]
        public virtual string VideoPath
        {
            get;
            set;
        }
    
        /// <summary>
        /// 基本上没有用
        /// </summary>
    	[DataMember]
    	[DisplayName("基本上没有用")]
        public virtual string VideoUrl
        {
            get;
            set;
        }
    
        /// <summary>
        /// 图片路径
        /// </summary>
    	[DataMember]
    	[DisplayName("图片路径")]
        public virtual string PicPath
        {
            get;
            set;
        }
    
        /// <summary>
        /// 图片文件
        /// </summary>
    	[DataMember]
    	[DisplayName("图片文件")]
        public virtual string PicFile
        {
            get;
            set;
        }
    
        /// <summary>
        /// 用户ID
        /// </summary>
    	[DataMember]
    	[DisplayName("用户ID")]
        public virtual Nullable<int> UserID
        {
            get;
            set;
        }
    
        /// <summary>
        /// 添加时间
        /// </summary>
    	[DataMember]
    	[DisplayName("添加时间")]
        public virtual Nullable<System.DateTime> AddTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// 来源
        /// </summary>
    	[DataMember]
    	[DisplayName("来源")]
        public virtual string InSource
        {
            get;
            set;
        }
    
        /// <summary>
        /// Aud
        /// </summary>
    	[DataMember]
    	[DisplayName("Aud")]
        public virtual Nullable<int> Aud
        {
            get;
            set;
        }
    
        /// <summary>
        /// AudTime
        /// </summary>
    	[DataMember]
    	[DisplayName("AudTime")]
        public virtual Nullable<System.DateTime> AudTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// 这个里面存的是和操作用户一样的数据
        /// </summary>
    	[DataMember]
    	[DisplayName("这个里面存的是和操作用户一样的数据")]
        public virtual Nullable<int> Auditor
        {
            get;
            set;
        }
    
        /// <summary>
        /// 是否推荐
        /// </summary>
    	[DataMember]
    	[DisplayName("是否推荐")]
        public virtual Nullable<int> IsVouch
        {
            get;
            set;
        }
    
        /// <summary>
        /// 推荐时间
        /// </summary>
    	[DataMember]
    	[DisplayName("推荐时间")]
        public virtual Nullable<System.DateTime> VouchTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// 是否删除
        /// </summary>
    	[DataMember]
    	[DisplayName("是否删除")]
        public virtual int IsDelete
        {
            get;
            set;
        }
    
        /// <summary>
        /// 删除时间
        /// </summary>
    	[DataMember]
    	[DisplayName("删除时间")]
        public virtual Nullable<System.DateTime> DeTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// 是否顶置
        /// </summary>
    	[DataMember]
    	[DisplayName("是否顶置")]
        public virtual Nullable<int> IsTop
        {
            get;
            set;
        }
    
        /// <summary>
        /// EquipmentID
        /// </summary>
    	[DataMember]
    	[DisplayName("EquipmentID")]
        public virtual Nullable<int> EquipmentID
        {
            get;
            set;
        }
    
        /// <summary>
        /// CommCount
        /// </summary>
    	[DataMember]
    	[DisplayName("CommCount")]
        public virtual Nullable<int> CommCount
        {
            get;
            set;
        }
    
        /// <summary>
        /// 顶置时间
        /// </summary>
    	[DataMember]
    	[DisplayName("顶置时间")]
        public virtual Nullable<System.DateTime> TopTime
        {
            get;
            set;
        }
    
        /// <summary>
        /// IsSuccess
        /// </summary>
    	[DataMember]
    	[DisplayName("IsSuccess")]
        public virtual Nullable<int> IsSuccess
        {
            get;
            set;
        }
    
        /// <summary>
        /// StoreCount
        /// </summary>
    	[DataMember]
    	[DisplayName("StoreCount")]
        public virtual Nullable<int> StoreCount
        {
            get;
            set;
        }
    
        /// <summary>
        /// TopCount
        /// </summary>
    	[DataMember]
    	[DisplayName("TopCount")]
        public virtual Nullable<int> TopCount
        {
            get;
            set;
        }
    
        /// <summary>
        /// Score
        /// </summary>
    	[DataMember]
    	[DisplayName("Score")]
        public virtual Nullable<int> Score
        {
            get;
            set;
        }

        #endregion
    }
}
