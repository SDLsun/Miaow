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
    /// TripList
    /// </summary>
    [Serializable]
    [DataContract]
    [FluentValidation.Attributes.Validator(typeof(Validate.TripListDtoValidate))]
    public partial class TripListDto
    {
        #region Primitive Properties
    
        /// <summary>
        /// 旅游ID
        /// </summary>
    	[DataMember]
    	[DisplayName("旅游ID")]
        public virtual int TripID
        {
            get;
            set;
        }
    
        /// <summary>
        /// 旅游标题
        /// </summary>
    	[DataMember]
    	[DisplayName("旅游标题")]
        public virtual string TripTitle
        {
            get;
            set;
        }
    
        /// <summary>
        /// 目的地
        /// </summary>
    	[DataMember]
    	[DisplayName("目的地")]
        public virtual string Termini
        {
            get;
            set;
        }
    
        /// <summary>
        /// 出发地
        /// </summary>
    	[DataMember]
    	[DisplayName("出发地")]
        public virtual string Spring
        {
            get;
            set;
        }
    
        /// <summary>
        /// 价格
        /// </summary>
    	[DataMember]
    	[DisplayName("价格")]
        public virtual Nullable<int> Price
        {
            get;
            set;
        }
    
        /// <summary>
        /// 出发时间
        /// </summary>
    	[DataMember]
    	[DisplayName("出发时间")]
        public virtual Nullable<System.DateTime> SpringDate
        {
            get;
            set;
        }
    
        /// <summary>
        /// URL 生成静态页面地址
        /// </summary>
    	[DataMember]
    	[DisplayName("URL 生成静态页面地址")]
        public virtual string TripFile
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
        /// 添加用户ID
        /// </summary>
    	[DataMember]
    	[DisplayName("添加用户ID")]
        public virtual Nullable<int> UserID
        {
            get;
            set;
        }
    
        /// <summary>
        /// 添加用户名
        /// </summary>
    	[DataMember]
    	[DisplayName("添加用户名")]
        public virtual string UserName
        {
            get;
            set;
        }
    
        /// <summary>
        /// 旅游天数
        /// </summary>
    	[DataMember]
    	[DisplayName("旅游天数")]
        public virtual Nullable<int> Days
        {
            get;
            set;
        }
    
        /// <summary>
        /// 添加时IP
        /// </summary>
    	[DataMember]
    	[DisplayName("添加时IP")]
        public virtual string Ip
        {
            get;
            set;
        }

        #endregion
    }
}
