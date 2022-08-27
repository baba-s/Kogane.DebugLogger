using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// UnityEngine.Debug でタグ付きのデバッグログを出力するクラス
    /// </summary>
    public sealed class TaggedDebugLogger : IDebugLogger
    {
        //================================================================================
        // 変数(readonly)
        //================================================================================
        private readonly string m_tag;    // Debug.Log に付与するタグ
        private readonly string m_format; // Debug.Log にタグを付与する際の書式

        //================================================================================
        // プロパティ
        //================================================================================
        public bool IsEnable { get; set; } = true;

        private string Format => m_format ?? DefaultFormat;

        //================================================================================
        // プロパティ(static)
        //================================================================================
        /// <summary>
        /// Debug.Log にタグを付与する際のデフォルトの書式を設定します
        /// </summary>
        public static string DefaultFormat { private get; set; } = "[{0}] {1}";

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TaggedDebugLogger( string tag, string format )
        {
            m_format = format;
            m_tag    = tag;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TaggedDebugLogger( string tag ) : this( tag, null )
        {
        }

        /// <summary>
        /// ログを出力します
        /// </summary>
        void IDebugLogger._LogImpl( object message, Object context )
        {
            Debug.Log( string.Format( Format, m_tag, message ), context );
        }

        /// <summary>
        /// 警告ログを出力します
        /// </summary>
        void IDebugLogger._LogWarningImpl( object message, Object context )
        {
            Debug.LogWarning( string.Format( Format, m_tag, message ), context );
        }

        /// <summary>
        /// エラーログを出力します
        /// </summary>
        void IDebugLogger._LogErrorImpl( object message, Object context )
        {
            Debug.LogError( string.Format( Format, m_tag, message ), context );
        }

        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// TaggedDebugLogger のインスタンスを作成して返します
        /// </summary>
        public static TaggedDebugLogger Create( string tag, string format )
        {
#if KOGANE_DISABLE_DEBUG_LOGGER
			return null;
#else
            return new TaggedDebugLogger( tag, format );
#endif
        }

        /// <summary>
        /// TaggedDebugLogger のインスタンスを作成して返します
        /// </summary>
        public static TaggedDebugLogger Create( string tag )
        {
#if KOGANE_DISABLE_DEBUG_LOGGER
			return null;
#else
            return new TaggedDebugLogger( tag );
#endif
        }
    }
}