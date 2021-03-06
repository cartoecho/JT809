﻿using JT809.Protocol.Interfaces;

namespace JT809.Protocol
{
    /// <summary>
    /// 子业务数据体
    /// </summary>
    public abstract class JT809SubBodies : IJT809Description
    {
        /// <summary>
        /// 跳过数据体序列化
        /// 默认不跳过
        /// 当数据体为空的时候，使用null作为空包感觉不适合，所以就算使用空包也需要new一下来表达意思。
        /// </summary>
        public virtual bool SkipSerialization { get; set; } = false;

        public abstract ushort SubMsgId { get; }

        public abstract string Description { get; }
    }
}
