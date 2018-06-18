﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleGameFramework.Event;
using System;

namespace SimpleGameFramework.DataTable
{
    /// <summary>
    /// 加载数据表更新事件
    /// </summary>
    public class LoadDataTableUpdateEventArgs : GlobalEventArgs
    {
        /// <summary>
        /// 加载数据表更新事件编号
        /// </summary>
        public static readonly int EventId = typeof(LoadDataTableUpdateEventArgs).GetHashCode();

        /// <summary>
        /// 加载数据表更新事件编号
        /// </summary>
        public override int Id
        {
            get
            {
                return EventId;
            }
        }

        /// <summary>
        /// 数据行的类型
        /// </summary>
        public Type DataRowType { get; private set; }

        /// <summary>
        /// 数据表名称
        /// </summary>
        public string DataTableName { get; private set; }

        /// <summary>
        /// 数据表资源名称
        /// </summary>
        public string DataTableAssetName { get; private set; }

        /// <summary>
        /// 加载数据表进度
        /// </summary>
        public float Progress { get; private set; }

        /// <summary>
        /// 用户自定义数据
        /// </summary>
        public object UserData { get; private set; }

        /// <summary>
        /// 清理加载数据表更新事件
        /// </summary>
        public override void Clear()
        {
            DataRowType = default(Type);
            DataTableName = default(string);
            DataTableAssetName = default(string);
            Progress = default(float);
            UserData = default(object);
        }

        /// <summary>
        /// 填充加载数据表更新事件
        /// </summary>
        /// <returns>加载数据表更新事件</returns>
        public LoadDataTableUpdateEventArgs Fill(object userData,string dataTableAssetName,float progress)
        {
            LoadDataTableInfo loadDataTableInfo = (LoadDataTableInfo)userData;
            DataRowType = loadDataTableInfo.DataRowType;
            DataTableName = loadDataTableInfo.DataTableName;
            DataTableAssetName = dataTableAssetName;
            Progress = progress;
            UserData = loadDataTableInfo.UserData;

            return this;
        }
    }
}

