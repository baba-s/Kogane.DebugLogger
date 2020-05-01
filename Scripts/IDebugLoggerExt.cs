﻿using UnityEngine;

namespace UniDebugLogger
{
	/// <summary>
	/// IDebugLogger 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class IDebugLoggerExt
	{
		//================================================================================
		// 定数
		//================================================================================
		private const string CONDITIONAL_STRING = "aCQHuF32pvyB";
		
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void Log( this IDebugLogger self, object message )
		{
			self._LogImpl( message, null );
		}

		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void Log( this IDebugLogger self, object message, Object context )
		{
			self._LogImpl( message, context );
		}

		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogFormat( this IDebugLogger self, string format, params object[] args )
		{
			self._LogImpl( string.Format( format, args ), null );
		}

		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogFormat( this IDebugLogger self, Object context, string format, params object[] args )
		{
			self._LogImpl( string.Format( format, args ), context );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogWarning( this IDebugLogger self, object message )
		{
			self._LogWarningImpl( message, null );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogWarning( this IDebugLogger self, object message, Object context )
		{
			self._LogWarningImpl( message, context );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogWarningFormat( this IDebugLogger self, string format, params object[] args )
		{
			self._LogWarningImpl( string.Format( format, args ), null );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogWarningFormat( this IDebugLogger self, Object context, string format, params object[] args )
		{
			self._LogWarningImpl( string.Format( format, args ), context );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogError( this IDebugLogger self, object message )
		{
			self._LogErrorImpl( message, null );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogError( this IDebugLogger self, object message, Object context )
		{
			self._LogErrorImpl( message, context );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogErrorFormat( this IDebugLogger self, string format, params object[] args )
		{
			self._LogErrorImpl( string.Format( format, args ), null );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogErrorFormat( this IDebugLogger self, Object context, string format, params object[] args )
		{
			self._LogErrorImpl( string.Format( format, args ), context );
		}
	}
}