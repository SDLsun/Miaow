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

using System.ComponentModel;
using System.Runtime.Serialization;
using Miaow.Domain.Dto.Validate;


namespace Miaow.Domain.Dto
{
    ////
    //using System.ComponentModel;
    //////using System.Runtime.Serialization;
    //
    /// <summary>
    /// sys_controllers
    /// </summary>
    [Serializable]
    [DataContract]
    [FluentValidation.Attributes.Validator(typeof(sys_controllersDtoValidate))]
    public partial class sys_controllersDto
    {
        #region Primitive Properties
    
        /// <summary>
        /// controllers_id
        /// </summary>
    	[DataMember]
    	[DisplayName("controllers_id")]
        public virtual string controllers_id
        {
            get;
            set;
        }
    
        /// <summary>
        /// controller_display_name
        /// </summary>
    	[DataMember]
    	[DisplayName("controller_display_name")]
        public virtual string controller_display_name
        {
            get;
            set;
        }
    
        /// <summary>
        /// controller_name
        /// </summary>
    	[DataMember]
    	[DisplayName("controller_name")]
        public virtual string controller_name
        {
            get;
            set;
        }
    
        /// <summary>
        /// action_name
        /// </summary>
    	[DataMember]
    	[DisplayName("action_name")]
        public virtual string action_name
        {
            get;
            set;
        }
    
        /// <summary>
        /// target_blank
        /// </summary>
    	[DataMember]
    	[DisplayName("target_blank")]
        public virtual int target_blank
        {
            get;
            set;
        }
    
        /// <summary>
        /// created_time
        /// </summary>
    	[DataMember]
    	[DisplayName("created_time")]
        public virtual System.DateTime created_time
        {
            get;
            set;
        }
    
        /// <summary>
        /// updated_time
        /// </summary>
    	[DataMember]
    	[DisplayName("updated_time")]
        public virtual Nullable<System.DateTime> updated_time
        {
            get;
            set;
        }
    
        /// <summary>
        /// remark
        /// </summary>
    	[DataMember]
    	[DisplayName("remark")]
        public virtual string remark
        {
            get;
            set;
        }
    
        /// <summary>
        /// admin_id
        /// </summary>
    	[DataMember]
    	[DisplayName("admin_id")]
        public virtual string admin_id
        {
            get;
            set;
        }
    
        /// <summary>
        /// deleted
        /// </summary>
    	[DataMember]
    	[DisplayName("deleted")]
        public virtual int deleted
        {
            get;
            set;
        }

        #endregion

    }
}