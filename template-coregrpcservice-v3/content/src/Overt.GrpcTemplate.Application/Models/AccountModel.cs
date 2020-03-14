using System;

namespace Overt.GrpcTemplate.Application.Models
{
    /// <summary>
    /// 账号 对应 AccountEntity
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public long AId { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 账号类型
        /// 1 主账号
        /// 2 子账号
        /// </summary>
        public int Password { get; set; }
        /// <summary>
        /// 商家Id 
        /// 主账号 UnionId == SupplierId
        /// </summary>
        public long Mobile { get; set; }
        /// <summary>
        /// 商家名称
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public DateTime ServiceStartTime { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public DateTime ServiceEndTime { get; set; }
        /// <summary>
        /// 最后登陆时间
        /// </summary>
        public int AStatus { get; set; }
        /// <summary>
        /// 设备数量
        /// </summary>
        public int DeviceCount { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }
    }
}