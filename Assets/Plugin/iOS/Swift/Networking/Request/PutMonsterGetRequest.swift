//
//  PutMonsterGetRequest.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Moya

struct PutMonstersGetRequest {

    let token: String
    let id: String
}

// MARK: - TargetType

extension PutMonstersGetRequest: TargetType {

    var path: String {
        return "/monsters/get"
    }

    var method: Moya.Method {
        return .put
    }

    var headers: [String: String]? {
        return ["Authorization": "Bearer \(token)"]
    }

    var task: Task {
        let parameters: Parameters = [
            "id": id
        ]
        return .requestParameters(parameters: parameters, encoding: JSONEncoding.default)
    }
}
