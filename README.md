# Kogane Debug Logger

タグ付きのデバッグログなどを使用できるパッケージ

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        IDebugLogger logger;

        logger = DefaultDebugLogger.Instance;

        logger.Log( "Log" );
        logger.Log( "Log", gameObject );
        logger.LogWarning( "LogWarning" );
        logger.LogWarning( "LogWarning", gameObject );
        logger.LogError( "LogError" );
        logger.LogError( "LogError", gameObject );
        logger.LogFormat( "LogFormat {0} / {1}", 1, 2 );
        logger.LogFormat( gameObject, "LogFormat {0} / {1}", 1, 2 );
        logger.LogWarningFormat( "LogWarningFormat {0} / {1}", 1, 2 );
        logger.LogWarningFormat( gameObject, "LogWarningFormat {0} / {1}", 1, 2 );
        logger.LogErrorFormat( "LogErrorFormat {0} / {1}", 1, 2 );
        logger.LogErrorFormat( gameObject, "LogErrorFormat {0} / {1}", 1, 2 );

        logger = TaggedDebugLogger.Create( "タイトル" );

        logger.Log( "Log" );
        logger.Log( "Log", gameObject );
        logger.LogWarning( "LogWarning" );
        logger.LogWarning( "LogWarning", gameObject );
        logger.LogError( "LogError" );
        logger.LogError( "LogError", gameObject );
        logger.LogFormat( "LogFormat {0} / {1}", 1, 2 );
        logger.LogFormat( gameObject, "LogFormat {0} / {1}", 1, 2 );
        logger.LogWarningFormat( "LogWarningFormat {0} / {1}", 1, 2 );
        logger.LogWarningFormat( gameObject, "LogWarningFormat {0} / {1}", 1, 2 );
        logger.LogErrorFormat( "LogErrorFormat {0} / {1}", 1, 2 );
        logger.LogErrorFormat( gameObject, "LogErrorFormat {0} / {1}", 1, 2 );

        logger = NullDebugLogger.Instance;

        logger.Log( "Log" );
        logger.Log( "Log", gameObject );
        logger.LogWarning( "LogWarning" );
        logger.LogWarning( "LogWarning", gameObject );
        logger.LogError( "LogError" );
        logger.LogError( "LogError", gameObject );
        logger.LogFormat( "LogFormat {0} / {1}", 1, 2 );
        logger.LogFormat( gameObject, "LogFormat {0} / {1}", 1, 2 );
        logger.LogWarningFormat( "LogWarningFormat {0} / {1}", 1, 2 );
        logger.LogWarningFormat( gameObject, "LogWarningFormat {0} / {1}", 1, 2 );
        logger.LogErrorFormat( "LogErrorFormat {0} / {1}", 1, 2 );
        logger.LogErrorFormat( gameObject, "LogErrorFormat {0} / {1}", 1, 2 );
    }
}
```

## 補足

- `KOGANE_DISABLE_DEBUG_LOGGER` シンボルを定義することですべてのデバッグログを無効化できる  