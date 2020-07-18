using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// UnityEngine.Debug でデバッグログを出力しないクラス
	/// </summary>
	public sealed class NullDebugLogger : IDebugLogger
	{
		//================================================================================
		// 変数(static)
		//================================================================================
		private static NullDebugLogger m_instance;
		
		//================================================================================
		// プロパティ
		//================================================================================
		public bool IsEnable { get; set; } = true;

		//================================================================================
		// プロパティ(static)
		//================================================================================
		public static NullDebugLogger Instance => 
#if DISABLE_UNI_DEBUG_LOGGER
			null;
#else
			m_instance ?? ( m_instance = new NullDebugLogger() );
#endif

		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// コンストラクタ
		/// </summary>
		private NullDebugLogger()
		{
		}

		/// <summary>
		/// ログを出力します
		/// </summary>
		void IDebugLogger._LogImpl( object message, Object context )
		{
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
		void IDebugLogger._LogWarningImpl( object message, Object context )
		{
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
		void IDebugLogger._LogErrorImpl( object message, Object context )
		{
		}
	}
}