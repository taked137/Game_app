//
//  GetMonstersMapRequest.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Moya

struct GetMonstersMapRequest {

    let token: String
}

// MARK: - TargetType

extension GetMonstersMapRequest: TargetType {

    var path: String {
        return "/monsters/map"
    }

    var method: Moya.Method {
        return .get
    }

    var headers: [String: String]? {
        return ["Authorization": "Bearer \(token)"]
    }

    var task: Task {
        return .requestPlain
    }
}
