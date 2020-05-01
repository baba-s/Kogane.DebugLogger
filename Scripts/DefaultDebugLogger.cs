using UnityEngine;

namespace UniDebugLogger
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
		// プロパティ(static)
		//================================================================================
		public static DefaultDebugLogger Instance =>
#if DISABLE_UNI_DEBUG_LOGGER
			null;
#else
			m_instance ?? ( m_instance = new DefaultDebugLogger() );
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
		public void _LogImpl( object message, Object context )
		{
			Debug.Log( message, context );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
		public void _LogWarningImpl( object message, Object context )
		{
			Debug.LogWarning( message, context );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
		public void _LogErrorImpl( object message, Object context )
		{
			Debug.LogError( message, context );
		}
	}
}