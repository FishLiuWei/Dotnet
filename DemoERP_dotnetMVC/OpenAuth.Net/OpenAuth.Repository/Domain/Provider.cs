﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.

// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAuth.Repository.Domain
{
    /// <summary>
	/// 供应商信息表
	/// </summary>
    public partial class Provider : Entity
    {
        public Provider()
        {
            this.ProviderNum = 0;
            this.ProviderName = string.Empty;
            this.Address = string.Empty;
            this.Telephone = "12345678901";
        }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public int ProviderNum { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string ProviderName { get; set; }
        /// <summary>
        /// 供应商地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Telephone { get; set; }
    }
}