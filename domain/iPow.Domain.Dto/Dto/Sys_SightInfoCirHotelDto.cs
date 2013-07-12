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
    /// Sys_SightInfoCirHotel
    /// </summary>
    [Serializable]
    [DataContract]
    [FluentValidation.Attributes.Validator(typeof(Validate.Sys_SightInfoCirHotelDtoValidate))]
    public partial class Sys_SightInfoCirHotelDto
    {
        #region Primitive Properties
    
        /// <summary>
        /// 自增ID
        /// </summary>
    	[DataMember]
    	[DisplayName("自增ID")]
        public virtual int Id
        {
            get;
            set;
        }
    
        /// <summary>
        /// 景区ID
        /// </summary>
    	[DataMember]
    	[DisplayName("景区ID")]
        public virtual Nullable<int> SightId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 酒店ID
        /// </summary>
    	[DataMember]
    	[DisplayName("酒店ID")]
        public virtual Nullable<int> HotelId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 来源
        /// </summary>
    	[DataMember]
    	[DisplayName("来源")]
        public virtual string Source
        {
            get;
            set;
        }
    
        /// <summary>
        /// 操作用户ID
        /// </summary>
    	[DataMember]
    	[DisplayName("操作用户ID")]
        public virtual Nullable<int> UserId
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
        /// 是否启用
        /// </summary>
    	[DataMember]
    	[DisplayName("是否启用")]
        public virtual Nullable<bool> State
        {
            get;
            set;
        }

        #endregion
    }
}
