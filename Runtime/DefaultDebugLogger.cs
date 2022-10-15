﻿using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// UnityEngine.Debug でデバッグログを出力するクラス
    /// </summary>
    public sealed class DefaultDebugLogger : IDebugLogger
    {
        //================================================================================
        // 変数(static)
        //================================================================================
        private static DefaultDebugLogger m_instance;

        //================================================================================
        // プロパティ
        //================================================================================
        public bool IsEnable { get; set; } = true;

        //================================================================================
        // プロパティ(static)
        //================================================================================
        public static DefaultDebugLogger Instance =>
#if KOGANE_DISABLE_DEBUG_LOGGER
			null;
#else
            m_instance ??= new();
#endif

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private DefaultDebugLogger()
        {
        }

        /// <summary>
        /// ログを出力します
        /// </summary>
        void IDebugLogger._LogImpl( object message, Object context )
        {
            Debug.Log( message, context );
        }

        /// <summary>
        /// 警告ログを出力します
        /// </summary>
        void IDebugLogger._LogWarningImpl( object message, Object context )
        {
            Debug.LogWarning( message, context );
        }

        /// <summary>
        /// エラーログを出力します
        /// </summary>
        void IDebugLogger._LogErrorImpl( object message, Object context )
        {
            Debug.LogError( message, context );
        }
    }
}