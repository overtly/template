using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Overt.GrpcTemplate.Domain.Entities
{
    /// <summary>
    /// 账号
    /// 单表
    /// </summary>
    [Table("Account")]
    public class AccountEntity
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AId { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 账号密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 服务开始时间
        /// </summary>
        public DateTime ServiceStartTime { get; set; }
        /// <summary>
        /// 服务结束时间
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
        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }
    }

}
