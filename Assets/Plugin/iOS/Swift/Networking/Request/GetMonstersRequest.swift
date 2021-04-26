//
//  GetMonstersRequest.swift
//  Unity-iPhone
//
//  Created by kntk on 2019/09/15.
//

import Moya

struct GetMonstersRequest {

    let token: String
}

// MARK: - TargetType

extension GetMonstersRequest: TargetType {

    var path: String {
        return "/monsters"
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
