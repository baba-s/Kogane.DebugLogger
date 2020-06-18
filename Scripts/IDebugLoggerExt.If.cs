using JetBrains.Annotations;
using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// IDebugLogger 型の拡張メソッドを管理するクラス
	/// </summary>
	public static partial class IDebugLoggerExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogIf( this IDebugLogger self, bool condition, object message )
		{
			if ( !condition ) return;
			self.Log( message );
		}

		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogIf( this IDebugLogger self, bool condition, object message, Object context )
		{
			if ( !condition ) return;
			self.Log( message, context );
		}

		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		[StringFormatMethod( "format" )]
		public static void LogFormatIf( this IDebugLogger self, bool condition, string format, params object[] args )
		{
			if ( !condition ) return;
			self.LogFormat( format, args );
		}

		/// <summary>
		/// ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		[StringFormatMethod( "format" )]
		public static void LogFormatIf( this IDebugLogger self, bool condition, Object context, string format, params object[] args )
		{
			if ( !condition ) return;
			self.LogFormat( context, format, args );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogWarningIf( this IDebugLogger self, bool condition, object message )
		{
			if ( !condition ) return;
			self.LogWarning( message );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogWarningIf( this IDebugLogger self, bool condition, object message, Object context )
		{
			if ( !condition ) return;
			self.LogWarning( message, context );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		[StringFormatMethod( "format" )]
		public static void LogWarningFormatIf( this IDebugLogger self, bool condition, string format, params object[] args )
		{
			if ( !condition ) return;
			self.LogWarningFormat( format, args );
		}

		/// <summary>
		/// 警告ログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		[StringFormatMethod( "format" )]
		public static void LogWarningFormatIf( this IDebugLogger self, bool condition, Object context, string format, params object[] args )
		{
			if ( !condition ) return;
			self.LogWarningFormat( context, format, args );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogErrorIf( this IDebugLogger self, bool condition, object message )
		{
			if ( !condition ) return;
			self.LogError( message );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		public static void LogErrorIf( this IDebugLogger self, bool condition, object message, Object context )
		{
			if ( !condition ) return;
			self.LogError( message, context );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		[StringFormatMethod( "format" )]
		public static void LogErrorFormatIf( this IDebugLogger self, bool condition, string format, params object[] args )
		{
			if ( !condition ) return;
			self.LogErrorFormat( format, args );
		}

		/// <summary>
		/// エラーログを出力します
		/// </summary>
#if DISABLE_UNI_DEBUG_LOGGER
		[System.Diagnostics.Conditional( CONDITIONAL_STRING )]
#endif
		[StringFormatMethod( "format" )]
		public static void LogErrorFormatIf( this IDebugLogger self, bool condition, Object context, string format, params object[] args )
		{
			if ( !condition ) return;
			self.LogErrorFormat( context, format, args );
		}
	}
}