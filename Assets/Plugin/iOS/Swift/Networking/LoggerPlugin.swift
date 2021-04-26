//
//  LoggerPlugin.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/16.
//

import Moya
import Result

struct LoggerPlugin: PluginType {

    func willSend(_ request: RequestType, target: TargetType) {
        request.request.map { print($0.curlString) }
    }

    func didReceive(_ result: Result<Response, MoyaError>, target: TargetType) {
        print(result.description)
    }
}
