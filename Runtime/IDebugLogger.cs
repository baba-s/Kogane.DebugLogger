using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// デバッグログを出力するインターフェイス
    /// </summary>
    public interface IDebugLogger
    {
        //================================================================================
        // プロパティ
        //================================================================================
        bool IsEnable { get; set; }

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// ログを出力します
        /// </summary>
        void _LogImpl( object message, Object context );

        /// <summary>
        /// 警告ログを出力します
        /// </summary>
        void _LogWarningImpl( object message, Object context );

        /// <summary>
        /// エラーログを出力します
        /// </summary>
        void _LogErrorImpl( object message, Object context );
    }
}