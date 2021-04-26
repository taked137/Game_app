using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class ErrorHandle: MonoBehaviour {

    public static void handle(Exception error) {
        string message;

        switch (error) {
            case AppError e:
                switch (e.kind) {
                    case ErrorKind.unauthorized:
                        message = "認証エラーが発生しました";
                        break;

                    case ErrorKind.notfound:
                        message = "サーバーが見つかりません";
                        break;

                    case ErrorKind._internal:
                        message = "サーバー準備中です";
                        break;

                    case ErrorKind.network:
                        message = "ネットワークエラー";
                        break;

                    default:
                        message = "ネットワークエラー";
                        break;
                }
                break;

            case JsonSerializationException e:
                message = "デコードエラー";
                break;
            
            default:
                message = "ネットワークエラー";
                break;
        }

        AlertBanner.show(message);
    }
}
